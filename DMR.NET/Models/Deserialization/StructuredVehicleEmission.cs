using System.ComponentModel;
using System.Xml.Serialization;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejNormStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredVehicleEmission
{
    [XmlElement("NormTypeStruktur")]
    public StructuredEmissionType? StructuredEmissionType { get; set; }
}

[XmlRoot("NormTypeStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredEmissionType
{
    [XmlElement("NormTypeNummer")]
    public string? EmissionStandard { get; set; }

    [XmlElement("NormTypeNavn")]
    public string? EmissionStandardName { get; set; }
}