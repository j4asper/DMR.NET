using System.ComponentModel;
using System.Xml.Serialization;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("SynResultatStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredInspectionResult
{
    [XmlElement("SynResultatSynsType")]
    public string? InspectionType { get; set; }

    /// <summary>
    /// The date and time when the vehicle inspection was performed.
    /// </summary>
    [XmlElement("SynResultatSynsDato")]
    public required DateTimeOffset InspectionDate { get; set; }

    /// <summary>
    /// The result of the vehicle's inspection, indicating whether it passed, failed, or was subject to specific conditions.
    /// </summary>
    [XmlElement("SynResultatSynsResultat")]
    public string? InspectionResult { get; set; }
}