using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum VehicleColor
{
    [XmlEnum("1")]
    Unknown = 1,

    [XmlEnum("2")]
    White = 2,
    
    [XmlEnum("3")]
    Grey = 3,

    [XmlEnum("4")]
    Black = 4,

    [XmlEnum("5")]
    Red = 5,

    [XmlEnum("6")]
    Brown = 6,

    [XmlEnum("7")]
    Yellow = 7,

    [XmlEnum("8")]
    Green = 8,

    [XmlEnum("9")]
    Blue = 9,

    [XmlEnum("10")]
    Orange = 10,

    [XmlEnum("11")]
    PurpleViolet = 11
}