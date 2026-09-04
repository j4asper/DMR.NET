using System.Xml.Serialization;
using System.ComponentModel;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KarrosseriTypeStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredVehicleChassis
{
    [XmlElement("KarrosseriTypeNavn")]
    public string? Name { get; set; }
}
