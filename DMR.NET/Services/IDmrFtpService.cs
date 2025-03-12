namespace DMR.NET.Services;

public interface IDmrFtpService
{
    double DownloadProgress { get; }
    
    bool DownloadInProgress { get; }
    
    Task<IReadOnlyList<string>> ListFilesAsync(CancellationToken cancellationToken = default);

    Task<string> GetLatestDmrDatabaseAsync(CancellationToken cancellationToken = default);

    Task<bool> LatestDmrDatabaseAvailable(CancellationToken cancellationToken = default);

    Task DownloadDmrDatabaseAsync(CancellationToken cancellationToken = default);
    
    ValueTask DisposeAsync();
}