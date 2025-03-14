using System.Xml.Serialization;

namespace DMR.NET.Entities.Models;

[XmlRoot("KoeretoejBetegnelseStruktur")]
public class StructuredVehicleDescription
{
    /// <summary>
    /// The brand or manufacturer of the vehicle, typically representing the company or entity that produces the vehicle.
    /// </summary>
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
    /// <summary>
    /// The specific model name of the vehicle, representing the particular version or configuration of the vehicle made by the manufacturer.
    /// </summary>
    [XmlElement("KoeretoejModelTypeNavn")]
    public required string ModelName { get; set; }
}

[XmlRoot("Variant")]
public class Variant
{
    /// <summary>
    /// The specific variant name of the vehicle, representing a particular version or configuration within a model line.
    /// </summary>
    [XmlElement("KoeretoejVariantTypeNavn")]
    public required string VariantName { get; set; }
}