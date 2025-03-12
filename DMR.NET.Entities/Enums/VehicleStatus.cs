using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum VehicleStatus
{
    Unknown,
    
    [XmlEnum("UnderOprettelse")]
    UnderCreation,

    [XmlEnum("Oprettet")]
    Created,

    [XmlEnum("Registreret")]
    Registered,

    [XmlEnum("Afmeldt")]
    Deregistered,

    [XmlEnum("Eksportmarkering")]
    ExportMarked,

    [XmlEnum("Skrottet")]
    Scrapped,

    [XmlEnum("Eksporteret")]
    Exported,

    [XmlEnum("AdministrativOprettelse")]
    AdministrativeCreation,

    [XmlEnum("Erklæretafimportør")]
    DeclaredByImporter,

    [XmlEnum("Erklæretafimportørogforhandler")]
    DeclaredByImporterAndDealer,

    [XmlEnum("Slettet")]
    Deleted,

    [XmlEnum("HarGennemførtRegistreringssyn")]
    CompletedRegistrationInspection,

    [XmlEnum("DelvistOprettet")]
    PartiallyCreated,
}