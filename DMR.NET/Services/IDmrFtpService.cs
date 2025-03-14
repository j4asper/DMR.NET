namespace DMR.NET.Services;

public interface IDmrFtpService
{
    /// <summary>
    /// Gets the current progress of the download as a percentage.
    /// </summary>
    /// <value>
    /// A <see cref="double"/> representing the percentage of the download that has been completed, ranging from 0 to 100.
    /// </value>
    double DownloadProgress { get; }
    
    /// <summary>
    /// Gets a value indicating whether a download is currently in progress.
    /// </summary>
    /// <value>
    /// <c>true</c> if a download is in progress; otherwise, <c>false</c>.
    /// </value>
    bool DownloadInProgress { get; }
    
    /// <summary>
    /// Asynchronously retrieves a list of file names from a specified directory on an FTP server.
    /// </summary>
    /// <param name="cancellationToken">A token to monitor for cancellation requests. Defaults to <see cref="CancellationToken.None"/>.</param>
    /// <returns>A task that represents the asynchronous operation, with a result of a read-only list of file names from the FTP directory.</returns>
    /// <exception cref="OperationCanceledException">Thrown if the operation is cancelled before completion.</exception>
    Task<IReadOnlyList<string>> ListFilesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously retrieves the name of the latest DMR database file from the FTP server.
    /// The latest file is determined based on the date value in the file name.
    /// </summary>
    /// <param name="cancellationToken">A token to monitor for cancellation requests. Defaults to <see cref="CancellationToken.None"/>.</param>
    /// <returns>A task that represents the asynchronous operation, with a result of the name of the latest DMR database file.</returns>
    /// <exception cref="OperationCanceledException">Thrown if the operation is cancelled before completion.</exception>
    /// <exception cref="InvalidOperationException">Thrown if no valid files are found or if the files do not follow the expected naming convention.</exception>
    Task<string> GetLatestDmrDatabaseAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously checks if the latest DMR database file is available locally and matches the size of the remote file on the FTP server.
    /// </summary>
    /// <param name="cancellationToken">A token to monitor for cancellation requests. Defaults to <see cref="CancellationToken.None"/>.</param>
    /// <returns>A task that represents the asynchronous operation, with a result indicating whether the latest DMR database file is available locally and matches the remote size.</returns>
    /// <exception cref="OperationCanceledException">Thrown if the operation is cancelled before completion.</exception>
    /// <exception cref="FileNotFoundException">Thrown if the file is not found locally.</exception>
    Task<bool> LatestDmrDatabaseAvailable(CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously downloads the latest DMR database file from the FTP server to a local destination.
    /// The method logs the download progress and ensures the file is overwritten if it already exists locally.
    /// </summary>
    /// <param name="cancellationToken">A token to monitor for cancellation requests. Defaults to <see cref="CancellationToken.None"/>.</param>
    /// <exception cref="OperationCanceledException">Thrown if the operation is cancelled during the download process.</exception>
    Task DownloadDmrDatabaseAsync(CancellationToken cancellationToken = default);
    
    ValueTask DisposeAsync();
}