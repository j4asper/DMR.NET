using System.Xml;
using DMR.NET.Entities.Models;

namespace DMR.NET.Services;

public interface IDmrDeserializerService
{
    /// <summary>
    /// Gets a value indicating whether the deserialization process is currently in progress.
    /// </summary>
    /// <value>
    /// <c>true</c> if deserialization is in progress; otherwise, <c>false</c>.
    /// </value>
    bool DeserializeInProgress { get; }
    
    /// <summary>
    /// Asynchronously deserializes DMR entries from a compressed XML file.
    /// This method reads the latest DMR database from a local zip archive, deserializes the data, and returns an asynchronous stream of DMR entries.
    /// </summary>
    /// <param name="cancellationToken">A token to monitor for cancellation requests. Defaults to <see cref="CancellationToken.None"/>.</param>
    /// <returns>An asynchronous enumerable of <see cref="DmrEntry"/> objects representing the deserialized entries from the XML file.</returns>
    /// <exception cref="OperationCanceledException">Thrown if downloading is in progress or if cancellation is requested during deserialization.</exception>
    /// <exception cref="FileNotFoundException">Thrown if the latest DMR database file is not found locally.</exception>
    /// <exception cref="XmlException">Thrown if there is an issue deserializing the DMR entries.</exception>
    IAsyncEnumerable<DmrEntry> DeserializeDmrEntriesAsync(CancellationToken cancellationToken = default);
}