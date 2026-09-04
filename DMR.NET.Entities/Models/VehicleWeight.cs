namespace DMR.NET.Entities.Models;

public class VehicleWeight
{
    public int? GrossWeight { get; set; }

    public int? CurbWeight { get; set; }

    public int? MinimumCurbWeight { get; set; }

    public int? MaximumCurbWeight { get; set; }

    public int? TechnicalGrossWeight { get; set; }

    public bool? TowingPossible { get; set; }

    public int? TowingWeightWithoutBrakes { get; set; }

    public int? TowingWeightWithBrakes { get; set; }
}
