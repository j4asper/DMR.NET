using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

public class VehicleEmission
{
    public required EmissionStandard Standard { get; set; }

    public required bool ParticleFilter { get; set; }
}
