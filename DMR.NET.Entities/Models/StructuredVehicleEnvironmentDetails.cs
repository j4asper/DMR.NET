using System.Xml.Serialization;

namespace DMR.NET.Entities.Models;

[XmlRoot("KoeretoejMiljoeOplysningStruktur")]
public class StructuredVehicleEnvironmentDetails
{
    [XmlElement("KoeretoejMiljoeOplysningPartikelFilter")]
    public required bool ParticleFilter { get; set; }
}