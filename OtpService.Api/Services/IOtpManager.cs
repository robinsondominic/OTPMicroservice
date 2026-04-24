namespace OtpService.Api.Services;

public interface IOtpManager
{
    string GenerateOtp(string identifier);
    bool ValidateOtp(string identifier, string pin);
}
