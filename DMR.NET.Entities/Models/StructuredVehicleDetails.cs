using System.Xml.Serialization;
using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

[XmlRoot("KoeretoejOplysningGrundStruktur")]
public class StructuredVehicleDetails
{
    /// <summary>
    /// The current status of the vehicle. This property represents the state of the vehicle in its lifecycle.
    /// </summary>
    [XmlElement("KoeretoejOplysningStatus")]
    public required VehicleStatus Status { get; set; }
    
    /// <summary>
    /// The date when the vehicle was first registered.
    /// </summary>
    [XmlElement("KoeretoejOplysningFoersteRegistreringDato")]
    public required DateTime FirstRegistrationDate { get; set; }

    /// <summary>
    /// The vehicle identification number (VIN) of the vehicle.
    /// </summary>
    [XmlElement("KoeretoejOplysningStelNummer")]
    public required string Vin { get; set; }

    /// <summary>
    /// The number of doors on the vehicle.
    /// </summary>
    [XmlElement("KoeretoejOplysningAntalDoere")]
    public required int? DoorCount { get; set; }

    /// <summary>
    /// The location where the vehicle identification number (VIN) is stamped or located on the vehicle.
    /// </summary>
    [XmlElement("KoeretoejOplysningStelNummerAnbringelse")]
    public required string? VinLocation { get; set; }

    /// <summary>
    /// The year of manufacture or model year of the vehicle.
    /// </summary>
    [XmlElement("KoeretoejOplysningModelAar")]
    public required int? ModelYear { get; set; }
    
    /// <summary>
    /// The EU variant code of the vehicle, which represents the specific configuration or variant of the vehicle model in the European market.
    /// </summary>
    [XmlElement("KoeretoejOplysningEUVariant")]
    public required string? EUVariant { get; set; }

    /// <summary>
    /// The EU version code of the vehicle, which indicates the version of the vehicle model according to European regulations or standards.
    /// </summary>
    [XmlElement("KoeretoejOplysningEUVersion")]
    public required string? EUVersion { get; set; }
    
    /// <summary>
    /// The name of the manufacturer of the vehicle.
    /// </summary>
    [XmlElement("KoeretoejOplysningFabrikant")]
    public required string? Manufacturer { get; set; }
    
    /// <summary>
    /// The rim and tire specification for the vehicle.
    /// </summary>
    [XmlElement("KoeretoejOplysningFaelgDaek")]
    public required string? RimTire { get; set; }

    /// <summary>
    /// The maximum speed the vehicle can achieve, in kilometers per hour.
    /// </summary>
    [XmlElement("KoeretoejOplysningMaksimumHastighed")]
    public required int? TopSpeed { get; set; }
    
    // [XmlElement("KoeretoejOplysningVVaerdiMekanisk")]
    // public required double ??? { get; set; }
    
    // [XmlElement("KoeretoejOplysningVVaerdiLuft")]
    // public required double ??? { get; set; }
    
    // [XmlElement("KoeretoejOplysningSkatteAkselAntal")]
    // public required int ??? { get; set; }
    
    // [XmlElement("KoeretoejOplysningSkatteAkselTryk")]
    // public required int ??? { get; set; }
    
    // [XmlElement("KoeretoejOplysningSkammelBelastning")]
    // public required int ??? { get; set; }
    
    // [XmlElement("KoeretoejOplysningSaettevognTilladtAkselTryk")]
    // public required int ??? { get; set; }
    
    /// <summary>
    /// The maximum allowed weight of the vehicle, including its cargo and any additional load.
    /// </summary>
    [XmlElement("KoeretoejOplysningTotalVaegt")]
    public required int? GrossWeight { get; set; }
    
    /// <summary>
    /// The weight of the vehicle in kilograms.
    /// </summary>
    [XmlElement("KoeretoejOplysningEgenVaegt")]
    public required int? Weight { get; set; }
    
    /// <summary>
    /// The minimum curb weight of the vehicle, which is the weight of the vehicle with standard equipment, fluids, and a full tank of fuel, but without passengers or cargo.
    /// </summary>
    [XmlElement("KoeretoejOplysningKoereklarVaegtMinimum")]
    public required int? MinimumCurbWeight { get; set; }

    /// <summary>
    /// The maximum curb weight of the vehicle, which is the weight of the vehicle with standard equipment, fluids, and a full tank of fuel, but without passengers or cargo.
    /// </summary>
    [XmlElement("KoeretoejOplysningKoereklarVaegtMaksimum")]
    public required int? MaximumCurbWeight { get; set; }

    // [XmlElement("KoeretoejOplysningTekniskTotalVaegt")]
    // public required int TechnicalGrossWeight { get; set; }
    
    /// <summary>
    /// The number of axles on the vehicle. This refers to the total number of axles (front and rear) supporting the vehicle.
    /// </summary>
    [XmlElement("KoeretoejOplysningAkselAntal")]
    public required int? AxleCount { get; set; }

    /// <summary>
    /// The driving axles of the vehicle, represented as a comma-separated string of axle numbers that provide power to the vehicle's wheels (e.g., "1,2" for a vehicle with two driving axles).
    /// </summary>
    /// <remarks>
    /// This property is stored as a string but represents an array of integers (e.g., "1,2" for axles 1 and 2). It specifies which axles are used to propel the vehicle.
    /// </remarks>
    [XmlElement("KoeretoejOplysningTraekkendeAksler")]
    public required string? DrivingAxles { get; set; } // int array
    
    /// <summary>
    /// The number of gears in the vehicle's transmission system.
    /// </summary>
    [XmlElement("KoeretoejOplysningAntalGear")]
    public required int? GearCount { get; set; }

    /// <summary>
    /// The total number of passengers the vehicle is designed to accommodate.
    /// </summary>
    [XmlElement("KoeretoejOplysningPassagerAntal")]
    public required int? PassengerCount { get; set; }

    /// <summary>
    /// The minimum number of seats in the vehicle, typically when the vehicle is configured with its most basic seating arrangement.
    /// </summary>
    [XmlElement("KoeretoejOplysningSiddepladserMinimum")]
    public required int? MinimumSeats { get; set; }

    /// <summary>
    /// The maximum number of seats in the vehicle, typically when the vehicle is configured with its full seating arrangement.
    /// </summary>
    [XmlElement("KoeretoejOplysningSiddepladserMaksimum")]
    public required int? MaximumSeats { get; set; }

    /// <summary>
    /// The minimum number of standing spots available in the vehicle, typically for vehicles designed to carry passengers standing (e.g., buses or trams).
    /// </summary>
    [XmlElement("KoeretoejOplysningStaapladserMinimum")]
    public required int? MinimumStandingSpots { get; set; }

    /// <summary>
    /// The maximum number of standing spots available in the vehicle, typically for vehicles designed to carry passengers standing (e.g., buses or trams).
    /// </summary>
    [XmlElement("KoeretoejOplysningStaapladserMaksimum")]
    public required int? MaximumStandingSpots { get; set; }

    /// <summary>
    /// Indicates whether the vehicle has the capability to tow a trailer or other vehicle.
    /// </summary>
    [XmlElement("KoeretoejOplysningTilkoblingMulighed")]
    public required bool? VehicleTowingPossibility { get; set; }

    /// <summary>
    /// The maximum weight that the vehicle can tow without brakes, typically referring to the weight of a trailer or another vehicle.
    /// </summary>
    [XmlElement("KoeretoejOplysningTilkoblingsvaegtUdenBremser")]
    public required int? TowingWeightWithoutBrakes { get; set; }

    /// <summary>
    /// The maximum weight that the vehicle can tow with brakes, typically referring to the weight of a trailer or another vehicle that has its own braking system.
    /// </summary>
    [XmlElement("KoeretoejOplysningTilkoblingsvaegtMedBremser")]
    public required int? TowingWeightWithBrakes { get; set; }
    
    /// <summary>
    /// Indicates whether the vehicle has passed the NCAP (New Car Assessment Program) safety test.
    /// </summary>
    [XmlElement("KoeretoejOplysningNCAPTest")]
    public required bool? NCAPTest { get; set; }

    /// <summary>
    /// Indicates whether the vehicle is suitable for use as a taxi.
    /// </summary>
    [XmlElement("KoeretoejOplysningEgnetTilTaxi")]
    public required bool? SuitableForTaxi { get; set; }

    /// <summary>
    /// Indicates whether the vehicle meets the criteria to be classified as a 30% van (i.e., a vehicle with a certain cargo area percentage).
    /// </summary>
    [XmlElement("KoeretoejOplysning30PctVarevogn")]
    public required bool? ThirtyPercentVan { get; set; }

    /// <summary>
    /// Indicates whether the vehicle is classified as a veteran vehicle, typically based on age and historical significance.
    /// </summary>
    [XmlElement("KoeretoejOplysningVeteranKoeretoejOriginal")]
    public required bool? Veteran { get; set; }

    /// <summary>
    /// Indicates whether the vehicle has been involved in a traffic accident and sustained damage.
    /// </summary>
    [XmlElement("KoeretoejOplysningTrafikskade")]
    public required bool? TrafficDamage { get; set; }

    /// <summary>
    /// The date when the vehicle was commissioned or put into service, indicating the start of its operational life.
    /// </summary>
    [XmlElement("KoeretoejOplysningIbrugtagningDato")]
    public required DateTime? CommissioningDate { get; set; }
    
    /// <summary>
    /// Additional equipment or features that are installed in or on the vehicle, not covered by the standard configuration.
    /// </summary>
    [XmlElement("KoeretoejOplysningOevrigtUdstyr")]
    public required string? OtherEquipment { get; set; }

    /// <summary>
    /// The vehicle identification number (VIN) of an attached sidecar, if applicable. This links the vehicle to its sidecar.
    /// </summary>
    [XmlElement("KoeretoejOplysningTilkobletSidevognStelnr")]
    public required string? AttachedSidecarVin { get; set; }

    /// <summary>
    /// The width of the vehicle's front track, which is the distance between the left and right wheels on the front axle.
    /// </summary>
    [XmlElement("KoeretoejOplysningSporviddenForrest")]
    public required int? TrackWidthFront { get; set; }

    /// <summary>
    /// The width of the vehicle's rear track, which is the distance between the left and right wheels on the rear axle.
    /// </summary>
    [XmlElement("KoeretoejOplysningSporviddenBagest")]
    public required int? TrackWidthBack { get; set; }
    
    /// <summary>
    /// The current condition of the vehicle, indicating its state of wear or quality.
    /// </summary>
    [XmlElement("KoeretoejOplysningKoeretoejstand")]
    public required VehicleCondition VehicleCondition { get; set; }
    
    [XmlElement("KoeretoejNormStruktur")]
    public required StructuredVehicleEmission StructuredVehicleEmission { get; set; }
    
    [XmlElement("KoeretoejBetegnelseStruktur")]
    public required StructuredVehicleDescription StructuredVehicleDescription { get; set; }
    
    [XmlElement("KoeretoejFarveStruktur")]
    public required StructuredVehicleColor StructuredVehicleColor { get; set; }
    
    [XmlElement("KoeretoejMiljoeOplysningStruktur")]
    public required StructuredVehicleEnvironmentDetails StructuredVehicleEnvironmentDetails { get; set; }
}