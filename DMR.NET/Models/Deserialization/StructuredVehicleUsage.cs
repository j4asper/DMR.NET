using System.ComponentModel;
using System.Xml.Serialization;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejAnvendelseStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredVehicleUsage
{
    [XmlElement("KoeretoejAnvendelseNummer")]
    public string? Usage { get; set; }

    [XmlElement("KoeretoejAnvendelseNavn")]
    public string? UsageName { get; set; }
}