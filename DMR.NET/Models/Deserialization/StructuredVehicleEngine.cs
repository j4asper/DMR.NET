using System.ComponentModel;
using System.Xml.Serialization;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejMotorStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredVehicleEngine
{
    [XmlElement("KoeretoejDrivmiddelSamlingStruktur")]
    public required StructuredVehiclePowerSourceCollection StructuredVehiclePowerSourceCollection { get; set; }
    
    /// <summary>
    /// The number of cylinders in the vehicle's engine, which can affect its performance and fuel efficiency.
    /// </summary>
    [XmlElement("KoeretoejMotorCylinderAntal")]
    public string? CylinderCount { get; set; }

    /// <summary>
    /// The total distance the vehicle has traveled, measured in kilometers.
    /// </summary>
    [XmlElement("KoeretoejMotorKilometerstand")]
    public string? Mileage { get; set; }
    
    [XmlElement("KoeretoejMotorInnovativTeknik")]
    public bool? InnovativeTechnology { get; set; }
}

[XmlRoot("KoeretoejDrivmiddelSamlingStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredVehiclePowerSourceCollection
{
    [XmlElement("KoeretoejDrivmiddelSamling")]
    public required VehiclePowerSourceCollection[] VehiclePowerSourceCollection { get; set; }
}

[XmlRoot("KoeretoejDrivmiddelSamling")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class VehiclePowerSourceCollection
{
    [XmlElement("DrivmiddelStruktur")]
    public required StructuredPowerSourceType StructuredPowerSourceType { get; set; }
}

[XmlRoot("DrivmiddelStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredPowerSourceType
{
    [XmlElement("DrivkraftTypeStruktur")]
    public required PropulsionPowerSourceType PropulsionPowerSourceType { get; set; }
    
    [XmlElement("KoeretoejBraendstofStruktur")]
    public required StructuredVehicleFuel StructuredVehicleFuel { get; set; }
    
    [XmlElement("KoeretoejMotorDrivmiddelPrimaer")]
    public required bool PrimarilyEnginePowered { get; set; }
}

[XmlRoot("DrivkraftTypeStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class PropulsionPowerSourceType
{
    [XmlElement("DrivkraftTypeNummer")]
    public string? PowerSourceType { get; set; }
}

[XmlRoot("KoeretoejBraendstofStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredVehicleFuel
{
    [XmlElement("KoeretoejMotorKmPerLiter")]
    public required string KmPerLiter { get; set; }
}