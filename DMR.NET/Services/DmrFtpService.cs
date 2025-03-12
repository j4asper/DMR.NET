using DMR.NET.Options;
using FluentFTP;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DMR.NET.Services;

public class DmrFtpService : IDmrFtpService, IAsyncDisposable
{
    private readonly string _sourcePath;
    private readonly string _destinationPath;
    private readonly AsyncFtpClient _ftpClient;
    private readonly ILogger<DmrFtpService> _logger;
    
    public double DownloadProgress { get; private set; }
    
    public bool DownloadInProgress { get; private set; }
    
    public DmrFtpService(string host, string username, string password, string sourcePath, string destinationPath, ILogger<DmrFtpService> logger)
    {
        _ftpClient = new AsyncFtpClient(host, username, password);
        _sourcePath = sourcePath;
        _destinationPath = destinationPath;
        _logger = logger;
    }
    
    public DmrFtpService(IOptions<DmrFtpOptions> options, ILogger<DmrFtpService> logger)
        : this(options.Value.Host, options.Value.Username, options.Value.Password, options.Value.SourcePath, options.Value.DestinationPath, logger) { }
    
    
    public async Task<IReadOnlyList<string>> ListFilesAsync(CancellationToken cancellationToken = default)
    {
        var items = await _ftpClient.GetListing(_sourcePath, cancellationToken);
        
        return items.Select(x => x.Name).ToList();
    }
    
    public async Task<string> GetLatestDmrDatabaseAsync(CancellationToken cancellationToken = default)
    {
        var files = await ListFilesAsync(cancellationToken);

        var latest = files.Select(x => int.Parse(x.Split("-")[1])).Max();
        
        return files.First(x => x.Contains(latest.ToString()));
    }

    public async Task<bool> LatestDmrDatabaseAvailable(CancellationToken cancellationToken = default)
    {
        var latestDmrDatabaseName = await GetLatestDmrDatabaseAsync(cancellationToken);

        var remoteSize = await _ftpClient.GetFileSize(_sourcePath + latestDmrDatabaseName, token: cancellationToken);

        if (!File.Exists(_destinationPath + latestDmrDatabaseName))
            return false;
        
        await using var stream = new FileStream(_destinationPath + latestDmrDatabaseName, FileMode.Open);
        
        var localSize = stream.Length;
        
        return remoteSize == localSize;
    }

    public async Task DownloadDmrDatabaseAsync(CancellationToken cancellationToken = default)
    {
        var latestDmrFileName = await GetLatestDmrDatabaseAsync(cancellationToken);
        
        var progress = new Progress<FtpProgress>(p => DownloadProgress = p.Progress);
        
        _logger.LogInformation("Starting download of file '{file}'", latestDmrFileName);

        DownloadInProgress = true;
        
        await _ftpClient.DownloadFile(_destinationPath + latestDmrFileName, _sourcePath + latestDmrFileName, FtpLocalExists.Overwrite, progress: progress, token: cancellationToken);
        
        DownloadInProgress = false;
        
        _logger.LogInformation("Download of file '{file}' is done", latestDmrFileName);
    }

    public async ValueTask DisposeAsync() => await _ftpClient.DisposeAsync();
}