using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum EmissionStandard
{
    Unknown,
    
    [XmlEnum("1")]
    NoNorm = 1,

    [XmlEnum("24")]
    Year2000MillionNorm = 24,

    [XmlEnum("25")]
    Year2005MillionNorm = 25,

    [XmlEnum("26")]
    NonEuro = 26,

    [XmlEnum("27")]
    EuroI = 27,

    [XmlEnum("28")]
    EuroII = 28,

    [XmlEnum("29")]
    EuroIII = 29,

    [XmlEnum("46")]
    EuroIV = 46,

    [XmlEnum("47")]
    EuroV = 47,

    [XmlEnum("48")]
    EEV = 48,

    [XmlEnum("49")]
    EuroVI = 49,

    [XmlEnum("50")]
    EuroVII = 50,

    [XmlEnum("77")]
    MillionNorm2006Over150ccm = 77,

    [XmlEnum("78")]
    MillionNorm2006Max150ccm = 78,
}