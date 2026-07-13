using System.Xml.Serialization;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejMiljoeOplysningStruktur")]
internal class StructuredVehicleEnvironmentDetails
{
    /// <summary>
    /// Indicates whether the vehicle is equipped with a particle filter.
    /// </summary>
    [XmlElement("KoeretoejMiljoeOplysningPartikelFilter")]
    internal required bool ParticleFilter { get; set; }
}