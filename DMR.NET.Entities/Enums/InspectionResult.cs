namespace DMR.NET.Entities.Enums;

public enum InspectionResult
{
    Unknown,
    
    PrivatePassengerUse,
    Approved,
    NotApproved,
    CanBeApprovedAfterReinspectionByInspectionCompany,
    CanBeApprovedAfterReinspectionBySynCompany,
    NotApprovedCanBeReproduced,
    NotFullyInspected
}