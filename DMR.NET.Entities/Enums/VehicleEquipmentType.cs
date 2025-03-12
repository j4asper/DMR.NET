using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum VehicleEquipmentType
{
    Unknown,

    [XmlEnum("401")]
    SteeringWheelControls = 401,

    [XmlEnum("402")]
    HeatedSteeringWheel = 402,

    [XmlEnum("403")]
    ElectricAdjustableSteeringWheel = 403,

    [XmlEnum("404")]
    MultifunctionSteeringWheel = 404,

    [XmlEnum("405")]
    HighSteering = 405,

    [XmlEnum("406")]
    LongForkMC = 406,

    [XmlEnum("502")]
    CeramicDiscs = 502,

    [XmlEnum("504")]
    FrontDiscBrakesMC = 504,

    [XmlEnum("505")]
    RearDiscBrakesMC = 505,

    [XmlEnum("506")]
    ABSBrakes = 506,

    [XmlEnum("601")]
    ParkingAssistant = 601,

    [XmlEnum("603")]
    OriginalCarAlarm = 603,

    [XmlEnum("605")]
    NavigationSystem = 605,

    [XmlEnum("607")]
    HiFiAudioSystem = 607,

    [XmlEnum("608")]
    VoiceControl = 608,

    [XmlEnum("711")]
    Compressor = 711,

    [XmlEnum("712")]
    Turbo = 712,

    [XmlEnum("713")]
    TunedEngine = 713,

    [XmlEnum("715")]
    FuelHeater = 715,

    [XmlEnum("717")]
    ESP = 717,

    [XmlEnum("718")]
    EngineNumberMC = 718,

    [XmlEnum("731")]
    ContinuouslyVariableGear = 731,

    [XmlEnum("732")]
    SixSpeedManual = 732,

    [XmlEnum("802")]
    ElectronicDampers = 802,

    [XmlEnum("804")]
    HeightAdjustableSuspension = 804,

    [XmlEnum("805")]
    FourWheelDrive = 805,

    [XmlEnum("905")]
    Targa = 905,

    [XmlEnum("908")]
    ElectricSunroof = 908,

    [XmlEnum("997")]
    SportsSeats = 997,

    [XmlEnum("998")]
    ElectricCurtainsInRearDoor = 998,

    [XmlEnum("999")]
    IntegratedChildSeat = 999,

    [XmlEnum("6010")]
    BackupCamera = 6010,

    [XmlEnum("6011")]
    LaneAssist = 6011,

    [XmlEnum("6012")]
    ManualClimateControl = 6012,

    [XmlEnum("6014")]
    SolarCooling = 6014,

    [XmlEnum("6015")]
    ThreeOrFourZoneClimate = 6015,

    [XmlEnum("6016")]
    OneOrTwoZoneClimate = 6016,

    [XmlEnum("6017")]
    HeatedFrontWindshield = 6017,

    [XmlEnum("6018")]
    ParkingControlRear = 6018,

    [XmlEnum("6019")]
    KeylessGo = 6019,

    [XmlEnum("6020")]
    CruiseControl = 6020,

    [XmlEnum("6021")]
    DistanceRadar = 6021,

    [XmlEnum("6022")]
    ParkingControlFront = 6022,

    [XmlEnum("6023")]
    ElectricDoorClosing = 6023,

    [XmlEnum("6024")]
    ElectricTailgate = 6024,

    [XmlEnum("6025")]
    LaneDepartureWarning = 6025,

    [XmlEnum("6026")]
    NightVisionEquipment = 6026,

    [XmlEnum("6027")]
    HeadUpDisplay = 6027,

    [XmlEnum("6028")]
    SeatbeltAlarm = 6028,

    [XmlEnum("6029")]
    Radio = 6029,

    [XmlEnum("8002")]
    AirSuspension = 8002,

    [XmlEnum("8010")]
    LargerWheelsOver20Inches = 8010,

    [XmlEnum("8013")]
    RigidFrameMC = 8013,

    [XmlEnum("8014")]
    SuspendedFrameMC = 8014,

    [XmlEnum("8015")]
    RebuiltFrameMC = 8015,

    [XmlEnum("9010")]
    MetallicPaint = 9010,

    [XmlEnum("9015")]
    RebuiltBody = 9015,

    [XmlEnum("9016")]
    GlassRoof = 9016,

    [XmlEnum("9017")]
    MetalFoldingRoof = 9017,

    [XmlEnum("9019")]
    NoSideWindowLeftSideCargo = 9019,

    [XmlEnum("9021")]
    ThreeOrMoreSeatsRows = 9021,

    [XmlEnum("9022")]
    XenonLights = 9022,

    [XmlEnum("9023")]
    DoubleCabin = 9023,

    [XmlEnum("9024")]
    CorneringLights = 9024,

    [XmlEnum("9901")]
    Airbags = 9901,

    [XmlEnum("9913")]
    ElectricAdjustableSeatsRear = 9913,

    [XmlEnum("9915")]
    SeatVentilation = 9915,

    [XmlEnum("9916")]
    SeatMassage = 9916,

    [XmlEnum("9917")]
    LeatherSeats = 9917,

    [XmlEnum("9918")]
    SuedeAlcantara = 9918,

    [XmlEnum("9919")]
    MemorySeatsFront = 9919,

    [XmlEnum("9920")]
    ElectricRearWindowCurtains = 9920,

    [XmlEnum("9921")]
    FixedSidePanniersMC = 9921,
}