using System.Xml.Serialization;
using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

[XmlRoot("Statistik", Namespace = "http://skat.dk/dmr/2007/05/31/")]
public class DmrEntry
{
    [XmlElement("KoeretoejIdent")]
    public required string Id { get; set; }

    [XmlElement("KoeretoejArtNummer")]
    public required VehicleType Type { get; set; }
    
    [XmlElement("KoeretoejAnvendelseStruktur")]
    public required StructuredVehicleUsage StructuredVehicleUsage { get; set; }
    
    [XmlElement("RegistreringNummerNummer")]
    public required string RegistrationNumber { get; set; }
    
    [XmlElement("RegistreringNummerUdloebDato")]
    public DateTimeOffset? RegistrationNumberExpiration { get; set; }
    
    [XmlElement("KoeretoejOplysningGrundStruktur")]
    public required StructuredVehicleDetails StructuredVehicleDetails { get; set; }
    
    [XmlElement("SynResultatStruktur")]
    public required StructuredInspectionResult StructuredInspectionResult { get; set; }

    [XmlElement("LeasingGyldigFra")]
    public DateTime? LeasingValidFrom { get; set; }
    
    [XmlElement("LeasingGyldigTil")]
    public DateTime? LeasingValidTo { get; set; }
}