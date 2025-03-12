using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum InspectionType
{
    Unknown,
    
    [XmlEnum("KontrolSyn")]
    ControlInspection,

    [XmlEnum("MOT")]
    MOT,

    [XmlEnum("PeriodiskSyn")]
    PeriodicInspection,

    [XmlEnum("RegistreringsSyn")]
    RegistrationInspection,

    [XmlEnum("RegistreringssynToldsyn")]
    RegistrationInspectionCustomsInspection,
}