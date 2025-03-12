using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum ChassisType
{
    Unknown,
    
    [XmlEnum("101")]
    StationWagon = 101,

    [XmlEnum("102")]
    Coupe = 102,

    [XmlEnum("103")]
    Cabriolet = 103,

    [XmlEnum("104")]
    Hatchback = 104,

    [XmlEnum("105")]
    Sedan = 105,

    [XmlEnum("106")]
    MPV = 106,

    [XmlEnum("303")]
    StationPickup = 303,

    [XmlEnum("304")]
    NoBody = 304,

    [XmlEnum("301")]
    ThreeWheeledOpen = 301,

    [XmlEnum("302")]
    ThreeWheeledClosed = 302
}