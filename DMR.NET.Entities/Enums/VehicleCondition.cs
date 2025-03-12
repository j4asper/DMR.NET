using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum VehicleCondition
{
    Unknown,
    
    [XmlEnum("Middel")]
    Average,
    
    [XmlEnum("UnderMiddel")]
    BelowAverage,
    
    [XmlEnum("OverMiddel")]
    AboveAverage,
}