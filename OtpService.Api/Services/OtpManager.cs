using Microsoft.Extensions.Caching.Memory;
using System.Security.Cryptography;

namespace OtpService.Api.Services;

public class OtpManager : IOtpManager
{
    private readonly IMemoryCache _cache;
    private readonly int _expirationMinutes = 5;

    public OtpManager(IMemoryCache cache, IConfiguration configuration)
    {
        _cache = cache;
        if (int.TryParse(configuration["OtpSettings:ExpirationMinutes"], out int exp))
        {
            _expirationMinutes = exp;
        }
    }

    public string GenerateOtp(string identifier)
    {
        string otp = RandomNumberGenerator.GetInt32(100000, 999999).ToString();
        var options = new MemoryCacheEntryOptions()
            .SetAbsoluteExpiration(TimeSpan.FromMinutes(_expirationMinutes));

        _cache.Set($"OTP_{identifier}", otp, options);
        return otp; 
    }

    public bool ValidateOtp(string identifier, string pin)
    {
        string cacheKey = $"OTP_{identifier}";
        if (_cache.TryGetValue(cacheKey, out string? storedOtp))
        {
            if (storedOtp == pin)
            {
                _cache.Remove(cacheKey);
                return true;
            }
        }
        return false;
    }
}
