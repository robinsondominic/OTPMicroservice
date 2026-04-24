using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using OtpService.Api.Services;
using System.Collections.Generic;
using Xunit;

namespace OtpService.Tests.Services;

public class OtpManagerTests
{
    private readonly IMemoryCache _cache;
    private readonly IConfiguration _configuration;
    private readonly OtpManager _otpManager;

    public OtpManagerTests()
    {
        _cache = new MemoryCache(new MemoryCacheOptions());
        var inMemorySettings = new Dictionary<string, string> {
            {"OtpSettings:ExpirationMinutes", "5"}
        };
        _configuration = new ConfigurationBuilder().AddInMemoryCollection(inMemorySettings).Build();
        _otpManager = new OtpManager(_cache, _configuration);
    }

    [Fact]
    public void GenerateOtp_ShouldReturn_6DigitString()
    {
        var otp = _otpManager.GenerateOtp("test@user.com");
        Assert.NotNull(otp);
        Assert.Equal(6, otp.Length);
        Assert.True(int.TryParse(otp, out _));
    }

    [Fact]
    public void ValidateOtp_WithCorrectPin_ShouldReturnTrue()
    {
        var identifier = "user@test.com";
        var otp = _otpManager.GenerateOtp(identifier);
        Assert.True(_otpManager.ValidateOtp(identifier, otp));
    }

    [Fact]
    public void ValidateOtp_WithIncorrectPin_ShouldReturnFalse()
    {
        var identifier = "user@test.com";
        _otpManager.GenerateOtp(identifier);
        Assert.False(_otpManager.ValidateOtp(identifier, "000000"));
    }

    [Fact]
    public void ValidateOtp_ShouldInvalidateOtp_AfterSingleUse()
    {
        var identifier = "user@test.com";
        var otp = _otpManager.GenerateOtp(identifier);
        Assert.True(_otpManager.ValidateOtp(identifier, otp));
        Assert.False(_otpManager.ValidateOtp(identifier, otp));
    }
}
