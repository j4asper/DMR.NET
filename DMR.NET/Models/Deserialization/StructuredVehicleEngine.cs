using System.Xml.Serialization;
using DMR.NET.Models.Deserialization.Enums;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejMotorStruktur")]
internal class StructuredVehicleEngine
{
    [XmlElement("KoeretoejDrivmiddelSamlingStruktur")]
    internal required StructuredVehiclePowerSourceCollection StructuredVehiclePowerSourceCollection { get; set; }
    
    /// <summary>
    /// The number of cylinders in the vehicle's engine, which can affect its performance and fuel efficiency.
    /// </summary>
    [XmlElement("KoeretoejMotorCylinderAntal")]
    internal string? CylinderCount { get; set; }

    /// <summary>
    /// The total distance the vehicle has traveled, measured in kilometers.
    /// </summary>
    [XmlElement("KoeretoejMotorKilometerstand")]
    internal string? Mileage { get; set; }
    
    [XmlElement("KoeretoejMotorInnovativTeknik")]
    internal bool? InnovativeTechnology { get; set; }
}

[XmlRoot("KoeretoejDrivmiddelSamlingStruktur")]
internal class StructuredVehiclePowerSourceCollection
{
    internal required VehiclePowerSourceCollection[] VehiclePowerSourceCollection { get; set; }
}

[XmlRoot("KoeretoejDrivmiddelSamling")]
internal class VehiclePowerSourceCollection
{
    [XmlElement("DrivmiddelStruktur")]
    internal required StructuredPowerSourceType StructuredPowerSourceType { get; set; }
}

[XmlRoot("DrivmiddelStruktur")]
internal class StructuredPowerSourceType
{
    [XmlElement("DrivkraftTypeStruktur")]
    internal required PropulsionPowerSourceType PropulsionPowerSourceType { get; set; }
    
    [XmlElement("KoeretoejBraendstofStruktur")]
    internal required StructuredVehicleFuel StructuredVehicleFuel { get; set; }
    
    [XmlElement("KoeretoejMotorDrivmiddelPrimaer")]
    internal required bool PrimarilyEnginePowered { get; set; }
}

[XmlRoot("DrivkraftTypeStruktur")]
internal class PropulsionPowerSourceType
{
    [XmlElement("DrivkraftTypeNummer")]
    internal required PowerSourceType PowerSourceType { get; set; }
}

[XmlRoot("KoeretoejBraendstofStruktur")]
internal class StructuredVehicleFuel
{
    [XmlElement("KoeretoejMotorKmPerLiter")]
    internal required string KmPerLiter { get; set; }
}