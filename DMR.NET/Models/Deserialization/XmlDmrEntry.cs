using System.ComponentModel;
using System.Xml.Serialization;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("Statistik", Namespace = "http://skat.dk/dmr/2007/05/31/")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class XmlDmrEntry
{
    [XmlElement("KoeretoejIdent")]
    public required string Id { get; set; }

    [XmlElement("KoeretoejArtNummer")]
    public string? Type { get; set; }
    
    [XmlElement("KoeretoejArtNavn")]
    public required string TypeName { get; set; }
    
    [XmlElement("KoeretoejAnvendelseStruktur")]
    public StructuredVehicleUsage? StructuredVehicleUsage { get; set; }
    
    [XmlElement("RegistreringNummerNummer")]
    public string? RegistrationNumber { get; set; }
    
    [XmlElement("RegistreringNummerUdloebDato")]
    public DateTimeOffset? RegistrationNumberExpiration { get; set; }
    
    [XmlElement("KoeretoejRegistreringStatus")]
    public required string RegistrationStatus { get; set; }
    
    [XmlElement("KoeretoejOplysningGrundStruktur")]
    public required StructuredVehicleDetails StructuredVehicleDetails { get; set; }
    
    [XmlElement("SynResultatStruktur")]
    public StructuredInspectionResult? StructuredInspectionResult { get; set; }

    [XmlElement("LeasingGyldigFra")]
    public DateTime? LeasingValidFrom { get; set; }
    
    [XmlElement("LeasingGyldigTil")]
    public DateTime? LeasingValidTo { get; set; }
}