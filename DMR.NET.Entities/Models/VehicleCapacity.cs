namespace DMR.NET.Entities.Models;

public class VehicleCapacity
{
    public int? DoorCount { get; set; }

    public int? AxleCount { get; set; }

    public int[]? DrivingAxles { get; set; }

    public int? GearCount { get; set; }

    public int? PassengerCount { get; set; }

    public int? MinimumSeats { get; set; }

    public int? MaximumSeats { get; set; }

    public int? MinimumStandingSpots { get; set; }

    public int? MaximumStandingSpots { get; set; }

    public int? TrackWidthFront { get; set; }

    public int? TrackWidthBack { get; set; }
}
