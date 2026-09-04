namespace DMR.NET.Entities.Models;

public class VehicleEngine
{
    public required VehiclePowerSource[] PowerSources { get; set; }

    public int? CylinderCount { get; set; }

    public int? Mileage { get; set; }

    public bool? InnovativeTechnology { get; set; }
}
