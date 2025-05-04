using System.Xml.Serialization;
using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

[XmlRoot("KoeretoejUdstyrSamlingStruktur")]
public class StructuredVehicleEquipment
{
    [XmlElement("KoeretoejUdstyrSamling")]
    public required VehicleEquipmentCollection VehicleEquipmentCollection { get; set; }
}

[XmlRoot("KoeretoejUdstyrSamling")]
public class VehicleEquipmentCollection
{
    public required StructuredEquipment[] StructuredEquipment { get; set; }
}

[XmlRoot("KoeretoejUdstyrStruktur")]
public class StructuredEquipment
{
    [XmlElement("KoeretoejUdstyrAntal")]
    public required int EquipmentCount { get; set; }
}

[XmlRoot("KoeretoejUdstyrTypeStruktur")]
public class StructuredVehicleEquipmentType
{
    [XmlElement("KoeretoejUdstyrTypeNummer")]
    public required VehicleEquipmentType VehicleEquipmentType { get; set; }
    
    [XmlElement("KoeretoejUdstyrTypeVisesVedSyn")]
    public required bool ShownDuringInspection { get; set; }

    [XmlElement("KoeretoejUdstyrTypeVisesVedForespoergsel")]
    public required bool ShownUponRequest { get; set; }
    
    [XmlElement("KoeretoejUdstyrTypeVisesVedStandardOprettelse")]
    public required bool ShownDuringStandardCreation { get; set; }
}