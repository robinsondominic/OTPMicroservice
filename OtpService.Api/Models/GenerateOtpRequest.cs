using System.ComponentModel.DataAnnotations;
namespace OtpService.Api.Models;

public class GenerateOtpRequest
{
    [Required]
    public string Identifier { get; set; } = string.Empty;
}
