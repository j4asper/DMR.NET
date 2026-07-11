using System.Xml.Serialization;
using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

[XmlRoot("KoeretoejNormStruktur")]
public class StructuredVehicleEmission
{
    [XmlElement("NormTypeStruktur")]
    public StructuredEmissionType? StructuredEmissionType { get; set; }
}

[XmlRoot("NormTypeStruktur")]
public class StructuredEmissionType
{
    [XmlElement("NormTypeNummer")]
    public required EmissionStandard EmissionStandard { get; set; }
    
    [XmlElement("NormTypeNavn")]
    public required string EmissionStandardName { get; set; }
}