namespace DMR.NET.Entities.Models;

public class DmrEntry
{
    /// <summary>
    /// Id of the vehicle in the DMR database
    /// </summary>
    public required string Id { get; set; }
    
    public required Registration Registration { get; set; }
}