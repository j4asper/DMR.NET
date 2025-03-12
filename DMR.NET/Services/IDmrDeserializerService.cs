using DMR.NET.Entities.Models;

namespace DMR.NET.Services;

public interface IDmrDeserializerService
{
    bool DeserializeInProgress { get; }
    
    IAsyncEnumerable<DmrEntry> DeserializeDmrEntriesAsync(CancellationToken cancellationToken = default);
}