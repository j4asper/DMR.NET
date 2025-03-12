using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum InspectionResult
{
    Unknown,
    
    [XmlEnum("1")]
    PrivatePassengerUse,

    [XmlEnum("Godkendt")]
    Approved,

    [XmlEnum("IkkeGodkendt")]
    NotApproved,

    [XmlEnum("KanGodkendesVedOmsynAfOmsynsvirksomhed")]
    CanBeApprovedAfterReinspectionByInspectionCompany,

    [XmlEnum("KanGodkendesVedOmsynAfSynsvirksomhed")]
    CanBeApprovedAfterReinspectionBySynCompany,

    [XmlEnum("IkkeGodkendtKanGenfremstilles")]
    NotApprovedCanBeReproduced,

    [XmlEnum("IkkeFuldstaendigtSyn")]
    NotFullyInspected
}