using System.Xml.Serialization;
using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

[XmlRoot("SynResultatStruktur")]
public class StructuredInspectionResult
{
    [XmlElement("SynResultatSynsType")]
    public required InspectionType InspectionType { get; set; }
    
    /// <summary>
    /// The date and time when the vehicle inspection was performed.
    /// </summary>
    [XmlElement("SynResultatSynsDato")]
    public required DateTimeOffset InspectionDate { get; set; }

    /// <summary>
    /// The result of the vehicle's inspection, indicating whether it passed, failed, or was subject to specific conditions.
    /// </summary>
    [XmlElement("SynResultatSynsResultat")]
    public required InspectionResult InspectionResult { get; set; }
}