using System.Xml.Serialization;
using DMR.NET.Models.Deserialization.Enums;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("SynResultatStruktur")]
internal class StructuredInspectionResult
{
    [XmlElement("SynResultatSynsType")]
    internal required InspectionType InspectionType { get; set; }
    
    /// <summary>
    /// The date and time when the vehicle inspection was performed.
    /// </summary>
    [XmlElement("SynResultatSynsDato")]
    internal required DateTimeOffset InspectionDate { get; set; }

    /// <summary>
    /// The result of the vehicle's inspection, indicating whether it passed, failed, or was subject to specific conditions.
    /// </summary>
    [XmlElement("SynResultatSynsResultat")]
    internal required InspectionResult InspectionResult { get; set; }
}