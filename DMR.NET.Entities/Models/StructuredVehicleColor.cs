using System.Xml.Serialization;
using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

[XmlRoot("KoeretoejFarveStruktur")]
public class StructuredVehicleColor
{
    [XmlElement("FarveTypeStruktur")]
    public required StructuredColorType StructuredColorType { get; set; }
}

[XmlRoot("FarveTypeStruktur")]
public class StructuredColorType
{
    [XmlElement("FarveTypeNummer")]
    public required VehicleColor VehicleColor { get; set; }
}