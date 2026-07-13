using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

public class Vehicle
{
    public required string Make { get; set; }
    
    public required string Model { get; set; }
    
    public required string Variant { get; set; }
    
    public required VehicleChassisType ChassisType { get; set; }
    
    public required VehicleColor Color { get; set; }
    
    public required VehicleCondition Condition { get; set; }
    
}