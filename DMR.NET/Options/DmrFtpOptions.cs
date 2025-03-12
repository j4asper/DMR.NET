using System.ComponentModel.DataAnnotations;

namespace DMR.NET.Options;

public class DmrFtpOptions
{
    public static readonly string DmrFtp = nameof(DmrFtp);
    
    [Required]
    public required string Host { get; set; }
    
    [Required]
    public required string Username { get; set; }
    
    [Required]
    public required string Password { get; set; }
    
    [Required]
    public required string SourcePath { get; set; }
    
    [Required]
    public required string DestinationPath { get; set; }
}