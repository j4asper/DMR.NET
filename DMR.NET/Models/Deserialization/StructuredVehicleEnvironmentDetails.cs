using System.ComponentModel;
using System.Xml.Serialization;

namespace DMR.NET.Models.Deserialization;

[XmlRoot("KoeretoejMiljoeOplysningStruktur")]
[EditorBrowsable(EditorBrowsableState.Never)]
public class StructuredVehicleEnvironmentDetails
{
    /// <summary>
    /// Indicates whether the vehicle is equipped with a particle filter.
    /// </summary>
    [XmlElement("KoeretoejMiljoeOplysningPartikelFilter")]
    public required bool ParticleFilter { get; set; }
}