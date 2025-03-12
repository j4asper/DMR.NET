using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum VehicleType
{
    Unknown,
    
    [XmlEnum("1")]
    PassengerCar = 1,

    [XmlEnum("2")]
    LargePassengerCar = 2,

    [XmlEnum("3")]
    Van = 3,

    [XmlEnum("4")]
    Truck = 4,

    [XmlEnum("5")]
    Trailer = 5,

    [XmlEnum("6")]
    SemiTrailer = 6,

    [XmlEnum("7")]
    Motorcycle = 7,

    [XmlEnum("8")]
    Tractor = 8,

    [XmlEnum("9")]
    TractorTrailer = 9,

    [XmlEnum("10")]
    Caravan = 10,

    [XmlEnum("11")]
    TowingEquipment = 11,

    [XmlEnum("12")]
    MotorEquipment = 12,

    [XmlEnum("16")]
    LargeMoped = 16,

    [XmlEnum("17")]
    SmallMoped = 17,

    [XmlEnum("91")]
    MotorizedBlockTrailer = 91,

    [XmlEnum("92")]
    BlockSemiTrailer = 92,

    [XmlEnum("93")]
    BlockTrailer = 93,

    [XmlEnum("94")]
    BlockDolly = 94,

    [XmlEnum("95")]
    BlockModule = 95,

    [XmlEnum("96")]
    BlockTrailerOnly = 96
}