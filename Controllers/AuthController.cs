using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Service;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly JwtService _jwtService;

        public AuthController(
            IAuthService authService,
            JwtService jwtService)
        {
            _authService = authService;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            var user = await _authService.LoginAsync(email, password);

            if (user == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            var token = _jwtService.GenerateToken(user);

            return Ok(new
            {
                token = token,
                userId = user.UserId,
                name = user.Name,
                email = user.Email,
                role = user.Role
            });
        }
    }
}