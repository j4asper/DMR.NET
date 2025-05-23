﻿using System.Xml.Serialization;
using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

[XmlRoot("KoeretoejMotorStruktur")]
public class StructuredVehicleEngine
{
    [XmlElement("KoeretoejDrivmiddelSamlingStruktur")]
    public required StructuredVehiclePowerSourceCollection StructuredVehiclePowerSourceCollection { get; set; }
    
    /// <summary>
    /// The number of cylinders in the vehicle's engine, which can affect its performance and fuel efficiency.
    /// </summary>
    [XmlElement("KoeretoejMotorCylinderAntal")]
    public int? CylinderCount { get; set; }

    /// <summary>
    /// The total distance the vehicle has traveled, measured in kilometers.
    /// </summary>
    [XmlElement("KoeretoejMotorKilometerstand")]
    public int? Mileage { get; set; }
    
    [XmlElement("KoeretoejMotorInnovativTeknik")]
    public bool? InnovativeTechnology { get; set; }
}

[XmlRoot("KoeretoejDrivmiddelSamlingStruktur")]
public class StructuredVehiclePowerSourceCollection
{
    public required VehiclePowerSourceCollection[] VehiclePowerSourceCollection { get; set; }
}

[XmlRoot("KoeretoejDrivmiddelSamling")]
public class VehiclePowerSourceCollection
{
    [XmlElement("DrivmiddelStruktur")]
    public required StructuredPowerSourceType StructuredPowerSourceType { get; set; }
}

[XmlRoot("DrivmiddelStruktur")]
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
public class PropulsionPowerSourceType
{
    [XmlElement("DrivkraftTypeNummer")]
    public required PowerSourceType PowerSourceType { get; set; }
}

[XmlRoot("KoeretoejBraendstofStruktur")]
public class StructuredVehicleFuel
{
    [XmlElement("KoeretoejMotorKmPerLiter")]
    public required double KmPerLiter { get; set; }
}