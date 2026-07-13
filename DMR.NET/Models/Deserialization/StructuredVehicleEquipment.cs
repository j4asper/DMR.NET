using System.Xml.Serialization;
using DMR.NET.Models.Deserialization.Enums;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejUdstyrSamlingStruktur")]
internal class StructuredVehicleEquipment
{
    [XmlElement("KoeretoejUdstyrSamling")]
    internal required VehicleEquipmentCollection VehicleEquipmentCollection { get; set; }
}

[XmlRoot("KoeretoejUdstyrSamling")]
internal class VehicleEquipmentCollection
{
    internal required StructuredEquipment[] StructuredEquipment { get; set; }
}

[XmlRoot("KoeretoejUdstyrStruktur")]
internal class StructuredEquipment
{
    [XmlElement("KoeretoejUdstyrAntal")]
    internal required int EquipmentCount { get; set; }
}

[XmlRoot("KoeretoejUdstyrTypeStruktur")]
internal class StructuredVehicleEquipmentType
{
    [XmlElement("KoeretoejUdstyrTypeNummer")]
    internal required VehicleEquipmentType VehicleEquipmentType { get; set; }
    
    [XmlElement("KoeretoejUdstyrTypeVisesVedSyn")]
    internal required bool ShownDuringInspection { get; set; }

    [XmlElement("KoeretoejUdstyrTypeVisesVedForespoergsel")]
    internal required bool ShownUponRequest { get; set; }
    
    [XmlElement("KoeretoejUdstyrTypeVisesVedStandardOprettelse")]
    internal required bool ShownDuringStandardCreation { get; set; }
}