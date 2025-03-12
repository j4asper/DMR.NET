using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum PowerSourceType
{
    Unknown,
    
    [XmlEnum("1")]
    Petrol = 1,

    [XmlEnum("2")]
    Diesel = 2,

    [XmlEnum("3")]
    FGas = 3,

    [XmlEnum("4")]
    Electric = 4,

    [XmlEnum("5")]
    Petroleum = 5,

    [XmlEnum("6")]
    NaturalGas = 6,

    [XmlEnum("7")]
    Hydrogen = 7
}