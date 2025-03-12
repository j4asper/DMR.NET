using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum VehicleUsage
{
    Unknown,
    
    [XmlEnum("1")]
    PrivatePassengerTransport = 1,

    [XmlEnum("20")]
    FreightTransport = 20,

    [XmlEnum("21")]
    TaxiTransport = 21,

    [XmlEnum("22")]
    MedicalTransport = 22,

    [XmlEnum("23")]
    AmbulanceTransport = 23,

    [XmlEnum("25")]
    RouteTransport = 25,

    [XmlEnum("26")]
    HearseTransport = 26,

    [XmlEnum("27")]
    CrewMaterialTransport = 27,

    [XmlEnum("28")]
    FireRescueTransport = 28,

    [XmlEnum("29")]
    PrivateBusTransport = 29,

    [XmlEnum("30")]
    BusTransport = 30,

    [XmlEnum("31")]
    TractorPowerForSemiTrailer = 31,

    [XmlEnum("32")]
    SpecialUse = 32,

    [XmlEnum("33")]
    ForestryAgricultureHorticultureTransport = 33,

    [XmlEnum("34")]
    ResidentialUse = 34,

    [XmlEnum("35")]
    WorkTransport = 35,

    [XmlEnum("38")]
    FreightTransportHalfVolume = 38,

    [XmlEnum("40")]
    CommercialFreightTransport = 40,

    [XmlEnum("41")]
    PrivateOrCommercialFreightTransport = 41,

    [XmlEnum("42")]
    PrivateFreightTransport = 42,

    [XmlEnum("43")]
    ApprovedForForestryAgricultureHorticultureOnly = 43,

    [XmlEnum("44")]
    ApprovedForRouteTransportOnly = 44,

    [XmlEnum("45")]
    SpecialTransport = 45,
    
    [XmlEnum("46")]
    LimousineService,
    
    [XmlEnum("47")]
    DrivingForPublicAuthority = 47
}