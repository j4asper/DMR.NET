using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

public class Vehicle
{
    public required string Make { get; set; }
    public required string Model { get; set; }
    public string? Variant { get; set; }
    public int? ModelYear { get; set; }

    public required string Vin { get; set; }
    public string? VinLocation { get; set; }

    public required VehicleChassisType ChassisType { get; set; }

    public required VehicleColor Color { get; set; }

    public required VehicleCondition Condition { get; set; }

    public int? TopSpeed { get; set; }

    public required VehicleStatus Status { get; set; }

    public required DateTime FirstRegistrationDate { get; set; }

    public string? Manufacturer { get; set; }

    public string? EUVariant { get; set; }

    public string? EUVersion { get; set; }

    public string? RimTire { get; set; }

    public DateTime? CommissioningDate { get; set; }

    public string? OtherEquipment { get; set; }

    public string? AttachedSidecarVin { get; set; }

    public bool? Veteran { get; set; }

    public bool? TrafficDamage { get; set; }

    public bool? SuitableForTaxi { get; set; }

    public bool? ThirtyPercentVan { get; set; }

    public bool? NCAPTest { get; set; }

    public required VehicleEngine Engine { get; set; }

    public required VehicleEmission Emission { get; set; }

    public required VehicleWeight Weight { get; set; }

    public required VehicleCapacity Capacity { get; set; }
}