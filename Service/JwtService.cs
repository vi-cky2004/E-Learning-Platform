using E_Learning_Platform.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_Learning_Platform.Service
{
    public class JwtService
    {
       private readonly IConfiguration _configuration;
       public JwtService (IConfiguration configuration)
       {
            _configuration = configuration;
       }
       public string GenerateToken(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var credntial= new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                                               issuer: _configuration["Jwt:Issuer"],
                                               audience: _configuration["Jwt:Audience"],
                                               claims: claims,
                                               expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Jwt:ExpiryMinutes"]))
                                            );

            var handler = new JwtSecurityTokenHandler();

            var jwtString = handler.WriteToken(token);

            return jwtString;

        }

    }
}
