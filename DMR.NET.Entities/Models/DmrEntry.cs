using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

public class DmrEntry
{
    /// <summary>
    /// Id of the vehicle in the DMR database
    /// </summary>
    public required string Id { get; set; }
    
    public required Registration Registration { get; set; }

    public required Vehicle Vehicle { get; set; }

    public VehicleInspection? Inspection { get; set; }

    public required VehicleType Type { get; set; }

    public required VehicleUsageType Usage { get; set; }

    public DateTime? LeasingValidFrom { get; set; }

    public DateTime? LeasingValidTo { get; set; }
}