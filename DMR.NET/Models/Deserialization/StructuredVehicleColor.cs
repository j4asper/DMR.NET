using System.Xml.Serialization;
using DMR.NET.Models.Deserialization.Enums;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejFarveStruktur")]
internal class StructuredVehicleColor
{
    [XmlElement("FarveTypeStruktur")]
    internal required StructuredColorType StructuredColorType { get; set; }
}

[XmlRoot("FarveTypeStruktur")]
internal class StructuredColorType
{
    [XmlElement("FarveTypeNummer")]
    internal required VehicleColor VehicleColor { get; set; }
}