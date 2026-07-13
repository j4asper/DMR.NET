using System.Xml.Serialization;
using DMR.NET.Models.Deserialization.Enums;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("Statistik", Namespace = "http://skat.dk/dmr/2007/05/31/")]
internal class XmlDmrEntry
{
    [XmlElement("KoeretoejIdent")]
    internal required string Id { get; set; }

    [XmlElement("KoeretoejArtNummer")]
    internal required VehicleType Type { get; set; }
    
    [XmlElement("KoeretoejArtNavn")]
    internal required string TypeName { get; set; }
    
    [XmlElement("KoeretoejAnvendelseStruktur")]
    internal required StructuredVehicleUsage StructuredVehicleUsage { get; set; }
    
    [XmlElement("RegistreringNummerNummer")]
    internal required string RegistrationNumber { get; set; }
    
    [XmlElement("RegistreringNummerUdloebDato")]
    internal DateTimeOffset? RegistrationNumberExpiration { get; set; }
    
    [XmlElement("KoeretoejRegistreringStatus")]
    internal required string RegistrationStatus { get; set; }
    
    [XmlElement("KoeretoejOplysningGrundStruktur")]
    internal required StructuredVehicleDetails StructuredVehicleDetails { get; set; }
    
    [XmlElement("SynResultatStruktur")]
    internal required StructuredInspectionResult StructuredInspectionResult { get; set; }

    [XmlElement("LeasingGyldigFra")]
    internal DateTime? LeasingValidFrom { get; set; }
    
    [XmlElement("LeasingGyldigTil")]
    internal DateTime? LeasingValidTo { get; set; }
}