using CasmanSln.RequestDtos;
using CasmanSln.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Casman.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] StaffRegisterRequestDto request)
        {
            try
            {
                var result = await _authService.Register(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult>StaffLogin([FromBody] LoginRequestDto request)
        {
            try
            {
                var response = await _authService.StaffLogin(request);

                if (request.StaffId==null || request.Password==null)
                    return BadRequest(new { message = "Both staffId and Password are required to login" });

                return Ok(response);
            }
            catch (Exception ex)
            {
                return Unauthorized("Invalid Credentials");
            }
        }
    }
}
