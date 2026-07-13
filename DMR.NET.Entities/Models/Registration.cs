namespace DMR.NET.Entities.Models;

public class Registration
{
    public required string RegistrationNumber { get; set; }
    
    public required string Status { get; set; }
    
    public required DateTime Expiration { get; set; }
}