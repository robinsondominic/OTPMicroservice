using Microsoft.AspNetCore.Mvc;
using OtpService.Api.Models;
using OtpService.Api.Services;

namespace OtpService.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OtpController : ControllerBase
{
    private readonly IOtpManager _otpManager;

    public OtpController(IOtpManager otpManager)
    {
        _otpManager = otpManager;
    }

    [HttpPost("generate")]
    public IActionResult Generate([FromBody] GenerateOtpRequest request)
    {
        var otp = _otpManager.GenerateOtp(request.Identifier);
        return Ok(ApiResponse<object>.Ok(new { MockOtp = otp }, "OTP generated successfully."));
    }

    [HttpPost("validate")]
    public IActionResult Validate([FromBody] ValidateOtpRequest request)
    {
        var isValid = _otpManager.ValidateOtp(request.Identifier, request.Pin);
        if (isValid)
            return Ok(ApiResponse<string>.Ok(null, "OTP validated successfully."));
            
        return BadRequest(ApiResponse<string>.Fail("Invalid or expired OTP."));
    }
}
