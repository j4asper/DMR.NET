using System.ComponentModel;
using System.Xml.Serialization;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejFarveStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredVehicleColor
{
    [XmlElement("FarveTypeStruktur")]
    public StructuredColorType? StructuredColorType { get; set; }
}

[XmlRoot("FarveTypeStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredColorType
{
    [XmlElement("FarveTypeNummer")]
    public string? VehicleColor { get; set; }
}