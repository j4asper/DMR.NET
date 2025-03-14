using System.Xml.Serialization;

namespace DMR.NET.Entities.Models;

[XmlRoot("KoeretoejMiljoeOplysningStruktur")]
public class StructuredVehicleEnvironmentDetails
{
    /// <summary>
    /// Indicates whether the vehicle is equipped with a particle filter.
    /// </summary>
    [XmlElement("KoeretoejMiljoeOplysningPartikelFilter")]
    public required bool ParticleFilter { get; set; }
}