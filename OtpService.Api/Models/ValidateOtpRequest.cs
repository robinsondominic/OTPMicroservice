using System.ComponentModel.DataAnnotations;
namespace OtpService.Api.Models;

public class ValidateOtpRequest
{
    [Required]
    public string Identifier { get; set; } = string.Empty;
    
    [Required]
    [StringLength(6, MinimumLength = 6)]
    public string Pin { get; set; } = string.Empty;
}
