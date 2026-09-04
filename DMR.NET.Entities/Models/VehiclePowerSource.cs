using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

public class VehiclePowerSource
{
    public required PowerSourceType Type { get; set; }

    public double? KmPerLiter { get; set; }

    public required bool IsPrimary { get; set; }
}
