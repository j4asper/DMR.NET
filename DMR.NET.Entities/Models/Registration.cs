namespace DMR.NET.Entities.Models;

public class Registration
{
    public string? RegistrationNumber { get; set; }
    
    public required string Status { get; set; }
    
    public required DateTime? Expiration { get; set; }
}