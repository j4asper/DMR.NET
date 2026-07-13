using System.Xml.Serialization;
using DMR.NET.Models.Deserialization.Enums;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejNormStruktur")]
internal class StructuredVehicleEmission
{
    [XmlElement("NormTypeStruktur")]
    internal StructuredEmissionType? StructuredEmissionType { get; set; }
}

[XmlRoot("NormTypeStruktur")]
internal class StructuredEmissionType
{
    [XmlElement("NormTypeNummer")]
    internal required EmissionStandard EmissionStandard { get; set; }
    
    [XmlElement("NormTypeNavn")]
    internal required string EmissionStandardName { get; set; }
}