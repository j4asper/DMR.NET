using System.Xml.Serialization;
using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

[XmlRoot("SynResultatStruktur")]
public class StructuredInspectionResult
{
    [XmlElement("SynResultatSynsType")]
    public required InspectionType InspectionType { get; set; }
    
    [XmlElement("SynResultatSynsDato")]
    public required DateTimeOffset InspectionDate { get; set; }
    
    [XmlElement("SynResultatSynsResultat")]
    public required InspectionResult InspectionResult { get; set; }
}