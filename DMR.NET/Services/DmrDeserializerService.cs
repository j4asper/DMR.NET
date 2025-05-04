using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;
using DMR.NET.Constants;
using DMR.NET.Entities.Models;
using DMR.NET.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DMR.NET.Services;

public class DmrDeserializerService : IDmrDeserializerService
{
    private readonly ILogger<DmrDeserializerService> _logger;
    private readonly IDmrFtpService _dmrFtpService;
    private readonly string _destinationPath;

    public bool DeserializeInProgress { get; private set; }
    
    public DmrDeserializerService(IDmrFtpService dmrFtpService, IOptions<DmrFtpOptions> options, ILogger<DmrDeserializerService> logger)
    {
        _dmrFtpService = dmrFtpService;
        _logger = logger;
        _destinationPath = options.Value.DestinationPath;
    }

    public async IAsyncEnumerable<DmrEntry> DeserializeDmrEntriesAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        if (_dmrFtpService.DownloadInProgress)
            throw new OperationCanceledException("Downloading is in progress.");

        var latestDmrDatabaseName = await _dmrFtpService.GetLatestDmrDatabaseAsync(cancellationToken);
        
        if (!File.Exists(_destinationPath + latestDmrDatabaseName))
            throw new FileNotFoundException("Latest dmr database was not found locally.");
        
        using var zipArchive = ZipFile.OpenRead(_destinationPath + latestDmrDatabaseName);
        
        var xmlEntry = zipArchive.GetEntry(FileNameConstants.InternalDmrXmlFile);

        if (xmlEntry is null)
            throw new OperationCanceledException($"Unable to load embedded {FileNameConstants.InternalDmrXmlFile} file.");

        DeserializeInProgress = true;
        
        await using var xmlStream = xmlEntry.Open();

        var settings = new XmlReaderSettings
        {
            ConformanceLevel = ConformanceLevel.Document,
            IgnoreWhitespace = true,
            Async = true
        };
        
        using var reader = XmlReader.Create(xmlStream, settings);

        var serializer = new XmlSerializer(typeof(DmrEntry));
        
        while (await reader.ReadAsync())
        {
            if (cancellationToken.IsCancellationRequested)
                break;
            
            if (reader.LocalName != "Statistik")
                continue;

            DmrEntry? entry = null;

            try
            {
                entry = (DmrEntry?)serializer.Deserialize(reader);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unable to deserialize DMR entry. Skipping entry...");
            }

            if (entry == null)
                continue;

            yield return entry;
        }
        
        DeserializeInProgress = false;
    }
}