using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum EmissionStandard
{
    Unknown,
    
    [XmlEnum("1")]
    NoStandard = 1,

    [XmlEnum("24")]
    Year2000EnvironmentalStandard = 24,

    [XmlEnum("25")]
    Year2005EnvironmentalStandard = 25,

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
    EnvironmentalStandard2006Over150ccm = 77,

    [XmlEnum("78")]
    EnvironmentalStandard2006Max150ccm = 78,
    
    [XmlEnum("79")]
    Euro5Plus = 79,
    
    [XmlEnum("80")]
    Euro1 = 80,
    
    [XmlEnum("81")]
    Euro2 = 81,
    
    [XmlEnum("82")]
    Euro3 = 82,
    
    [XmlEnum("83")]
    Euro4 = 83,
    
    [XmlEnum("84")]
    Euro5A = 84,
    
    [XmlEnum("85")]
    Euro5B = 85,
    
    [XmlEnum("86")]
    Euro6B = 86,
    
    [XmlEnum("87")]
    Euro6C = 87,

    [XmlEnum("88")]
    Euro6DTemp = 88,
    
    [XmlEnum("89")]
    Euro6D = 89,

    [XmlEnum("90")]
    Euro6E = 90,
    
    [XmlEnum("91")]
    Euro7 = 91,
    
    [XmlEnum("92")]
    Euro5 = 92,
        
    [XmlEnum("94")]
    Euro6 = 94
}