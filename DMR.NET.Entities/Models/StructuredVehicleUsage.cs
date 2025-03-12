using System.Xml.Serialization;
using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

[XmlRoot("KoeretoejAnvendelseStruktur")]
public class StructuredVehicleUsage
{
    [XmlElement("KoeretoejAnvendelseNummer")]
    public required VehicleUsage Usage { get; set; }
}