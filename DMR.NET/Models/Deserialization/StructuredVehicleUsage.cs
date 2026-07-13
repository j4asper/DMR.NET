using System.Xml.Serialization;
using DMR.NET.Models.Deserialization.Enums;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejAnvendelseStruktur")]
internal class StructuredVehicleUsage
{
    [XmlElement("KoeretoejAnvendelseNummer")]
    internal required VehicleUsage Usage { get; set; }
    
    [XmlElement("KoeretoejAnvendelseNavn")]
    internal required string UsageName { get; set; }
}