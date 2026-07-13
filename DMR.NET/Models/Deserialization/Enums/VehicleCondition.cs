using System.Xml.Serialization;

namespace DMR.NET.Models.Deserialization.Enums;

internal enum VehicleCondition
{
    Unknown,
    
    [XmlEnum("Middel")]
    Average,
    
    [XmlEnum("UnderMiddel")]
    BelowAverage,
    
    [XmlEnum("OverMiddel")]
    AboveAverage,
}