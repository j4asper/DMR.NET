using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;
using DMR.NET.Entities.Models;
using DMR.NET.Mappers;
using DMR.NET.Models.Deserialization;
using DMR.NET.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DMR.NET.Services;

public class DmrDeserializerService : IDmrDeserializerService
{
    private readonly ILogger<DmrDeserializerService> _logger;
    private readonly IDmrFtpService _dmrFtpService;
    private readonly DmrFtpOptions _dmrFtpOptions;

    public bool DeserializeInProgress { get; private set; }
    
    public DmrDeserializerService(IDmrFtpService dmrFtpService, IOptions<DmrFtpOptions> options, ILogger<DmrDeserializerService> logger)
    {
        _dmrFtpService = dmrFtpService;
        _logger = logger;
        _dmrFtpOptions = options.Value;
    }

    public async IAsyncEnumerable<DmrEntry> DeserializeDmrEntriesAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        if (_dmrFtpService.DownloadInProgress)
            throw new OperationCanceledException("Downloading is in progress.");

        var latestDmrDatabaseName = await _dmrFtpService.GetLatestDmrDatabaseAsync(cancellationToken);
        
        if (!File.Exists(_dmrFtpOptions.DestinationPath + latestDmrDatabaseName))
            throw new FileNotFoundException("Latest dmr database was not found locally.");

        await using var zipArchive = await ZipFile.OpenReadAsync(_dmrFtpOptions.DestinationPath + latestDmrDatabaseName, cancellationToken);
        
        var xmlEntry = zipArchive.GetEntry(_dmrFtpOptions.InternalXmlFileName);

        if (xmlEntry is null)
            throw new OperationCanceledException($"Unable to load embedded {_dmrFtpOptions.InternalXmlFileName} file.");

        DeserializeInProgress = true;
        
        try
        {
            await using var rawXmlStream = await xmlEntry.OpenAsync(cancellationToken);
        
            using var bufferedStream = new BufferedStream(rawXmlStream, 128 * 1024);

            var settings = new XmlReaderSettings
            {
                ConformanceLevel = ConformanceLevel.Document,
                IgnoreWhitespace = true,
                Async = false
            };
        
            using var reader = XmlReader.Create(bufferedStream, settings);
            var serializer = new XmlSerializer(typeof(XmlDmrEntry));
            
            while (reader.Read())
            {
                if (cancellationToken.IsCancellationRequested)
                    break;
            
                if (reader.NodeType != XmlNodeType.Element || reader.LocalName != "Statistik")
                    continue;
                
                var entry = (XmlDmrEntry?)serializer.Deserialize(reader);

                if (entry != null)
                {
                    yield return entry.MapToDmrEntry();
                }
            }
        }
        finally
        {
            DeserializeInProgress = false;
        }
    }
}