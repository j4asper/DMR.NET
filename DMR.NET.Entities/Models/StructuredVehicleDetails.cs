using System.Xml.Serialization;
using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

[XmlRoot("KoeretoejOplysningGrundStruktur")]
public class StructuredVehicleDetails
{
    [XmlElement("KoeretoejOplysningStatus")]
    public required VehicleStatus Status { get; set; }
    
    [XmlElement("KoeretoejOplysningFoersteRegistreringDato")]
    public required DateTime FirstRegistrationDate { get; set; }
    
    [XmlElement("KoeretoejOplysningStelNummer")]
    public required string Vin { get; set; }
    
    [XmlElement("KoeretoejOplysningAntalDoere")]
    public required int DoorCount  { get; set; }
        
    [XmlElement("KoeretoejOplysningStelNummerAnbringelse")]
    public required string VinLocation { get; set; }
    
    [XmlElement("KoeretoejOplysningModelAar")]
    public required int ModelYear  { get; set; }
    
    [XmlElement("KoeretoejOplysningEUVariant")]
    public required string EUVariant { get; set; }
    
    [XmlElement("KoeretoejOplysningEUVersion")]
    public required string EUVersion { get; set; }
    
    [XmlElement("KoeretoejOplysningFabrikant")]
    public required string Manufacturer { get; set; }
    
    [XmlElement("KoeretoejOplysningFaelgDaek")]
    public required string RimTire { get; set; }
    
    [XmlElement("KoeretoejOplysningMaksimumHastighed")]
    public required int TopSpeed { get; set; }
    
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
    
    [XmlElement("KoeretoejOplysningTotalVaegt")]
    public required int GrossWeight { get; set; }
    
    [XmlElement("KoeretoejOplysningEgenVaegt")]
    public required int Weight { get; set; }
    
    [XmlElement("KoeretoejOplysningKoereklarVaegtMinimum")]
    public required int MinimumCurbWeight { get; set; }
    
    [XmlElement("KoeretoejOplysningKoereklarVaegtMaksimum")]
    public required int MaximumCurbWeight { get; set; }

    // [XmlElement("KoeretoejOplysningTekniskTotalVaegt")]
    // public required int TechnicalGrossWeight { get; set; }
    
    [XmlElement("KoeretoejOplysningAkselAntal")]
    public required int AxleCount { get; set; }
    
    [XmlElement("KoeretoejOplysningTraekkendeAksler")]
    public required string DrivingAxles { get; set; } // int array
    
    [XmlElement("KoeretoejOplysningAntalGear")]
    public required int GearCount  { get; set; }
    
    [XmlElement("KoeretoejOplysningPassagerAntal")]
    public required int PassengerCount { get; set; }
    
    [XmlElement("KoeretoejOplysningSiddepladserMinimum")]
    public required int MinimumSeats { get; set; }
    
    [XmlElement("KoeretoejOplysningSiddepladserMaksimum")]
    public required int MaximumSeats { get; set; }
    
    [XmlElement("KoeretoejOplysningStaapladserMinimum")]
    public required int MinimumStandingSpots  { get; set; }
    
    [XmlElement("KoeretoejOplysningStaapladserMaksimum")]
    public required int MaximumStandingSpots  { get; set; }
    
    [XmlElement("KoeretoejOplysningTilkoblingMulighed")]
    public required bool VehicleTowingPossibility { get; set; }
    
    [XmlElement("KoeretoejOplysningTilkoblingsvaegtUdenBremser")]
    public required int TowingWeightWithoutBrakes { get; set; }
    
    [XmlElement("KoeretoejOplysningTilkoblingsvaegtMedBremser")]
    public required int TowingWeightWithBrakes { get; set; }
    
    [XmlElement("KoeretoejOplysningNCAPTest")]
    public required bool NCAPTest { get; set; }
    
    [XmlElement("KoeretoejOplysningEgnetTilTaxi")]
    public required bool SuitableForTaxi { get; set; }
    
    [XmlElement("KoeretoejOplysning30PctVarevogn")]
    public required bool ThirtyPercentVan { get; set; }
    
    [XmlElement("KoeretoejOplysningVeteranKoeretoejOriginal")]
    public required bool Veteran { get; set; }
    
    [XmlElement("KoeretoejOplysningTrafikskade")]
    public required bool TrafficDamage { get; set; }
    
    [XmlElement("KoeretoejOplysningIbrugtagningDato")]
    public required DateTime CommissioningDate { get; set; }
    
    [XmlElement("KoeretoejOplysningOevrigtUdstyr")]
    public required string OtherEquipment { get; set; }
    
    [XmlElement("KoeretoejOplysningTilkobletSidevognStelnr")]
    public required string AttachedSidecarVin  { get; set; }
    
    [XmlElement("KoeretoejOplysningSporviddenForrest")]
    public required int TrackWidthFront  { get; set; }
    
    [XmlElement("KoeretoejOplysningSporviddenBagest")]
    public required int TrackWidthBack  { get; set; }
    
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