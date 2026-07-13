using System.Xml.Serialization;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejBetegnelseStruktur")]
internal class StructuredVehicleDescription
{
    /// <summary>
    /// The brand or manufacturer of the vehicle, typically representing the company or entity that produces the vehicle.
    /// </summary>
    [XmlElement("KoeretoejMaerkeTypeNavn")]
    internal required string Make { get; set; }
    
    [XmlElement("Model")]
    internal required Model Model { get; set; }
    
    [XmlElement("Variant")]
    internal required Variant Variant { get; set; }
}

[XmlRoot("Model")]
internal class Model
{
    /// <summary>
    /// The specific model name of the vehicle, representing the particular version or configuration of the vehicle made by the manufacturer.
    /// </summary>
    [XmlElement("KoeretoejModelTypeNavn")]
    internal required string ModelName { get; set; }
}

[XmlRoot("Variant")]
internal class Variant
{
    /// <summary>
    /// The specific variant name of the vehicle, representing a particular version or configuration within a model line.
    /// </summary>
    [XmlElement("KoeretoejVariantTypeNavn")]
    internal required string VariantName { get; set; }
}