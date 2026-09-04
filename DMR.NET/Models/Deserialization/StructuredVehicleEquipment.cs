using System.Xml.Serialization;
using DMR.NET.Models.Deserialization.Enums;
using System.ComponentModel;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejUdstyrSamlingStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredVehicleEquipment
{
    [XmlElement("KoeretoejUdstyrSamling")]
    public required VehicleEquipmentCollection VehicleEquipmentCollection { get; set; }
}

[XmlRoot("KoeretoejUdstyrSamling")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class VehicleEquipmentCollection
{
    public required StructuredEquipment[] StructuredEquipment { get; set; }
}

[XmlRoot("KoeretoejUdstyrStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredEquipment
{
    [XmlElement("KoeretoejUdstyrAntal")]
    public required int EquipmentCount { get; set; }
}

[XmlRoot("KoeretoejUdstyrTypeStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
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