using System.Xml.Serialization;

namespace DMR.NET.Entities.Models;

[XmlRoot("KoeretoejBetegnelseStruktur")]
public class StructuredVehicleDescription
{
    [XmlElement("KoeretoejMaerkeTypeNavn")]
    public required string Make { get; set; }
    
    [XmlElement("Model")]
    public required Model Model { get; set; }
    
    [XmlElement("Variant")]
    public required Variant Variant { get; set; }
}

[XmlRoot("Model")]
public class Model
{
    [XmlElement("KoeretoejModelTypeNavn")]
    public required string ModelName { get; set; }
}

[XmlRoot("Variant")]
public class Variant
{
    [XmlElement("KoeretoejVariantTypeNavn")]
    public required string VariantName { get; set; }
}