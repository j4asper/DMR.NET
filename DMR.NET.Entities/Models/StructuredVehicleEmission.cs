using System.Xml.Serialization;
using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

[XmlRoot("KoeretoejNormStruktur")]
public class StructuredVehicleEmission
{
    [XmlElement("NormTypeStruktur")]
    public required StructuredEmissionType StructuredEmissionType { get; set; }
}

[XmlRoot("NormTypeStruktur")]
public class StructuredEmissionType
{
    [XmlElement("NormTypeNummer")]
    public required EmissionStandard EmissionStandard { get; set; }
}