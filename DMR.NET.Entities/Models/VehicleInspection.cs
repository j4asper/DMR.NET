using DMR.NET.Entities.Enums;

namespace DMR.NET.Entities.Models;

public class VehicleInspection
{
    public required DateTime Date { get; set; }
    
    public required InspectionResult Result { get; set; }
    
    public required InspectionType Type { get; set; }
}