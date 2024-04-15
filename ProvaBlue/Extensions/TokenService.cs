using Microsoft.IdentityModel.Tokens;
using ProvaBlue.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ProvaBlue.Extensions {
    public class TokenService {

        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration config) {
            _configuration = config;
        }

        public TokenService() {
            
        }

        public string GenerateToken(UserModel user) {

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]);
            // Ou, caso queira armazenar a key numa variável de ambiente e não no appsettings.json:
            // var key = Environment.GetEnvironmentVariable("JWT_KEY");

            var tokenDescription = new SecurityTokenDescriptor {

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Expires = DateTime.UtcNow.AddHours(2),
                Subject = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Role, user.Role)
                })

            };

            var token = tokenHandler.CreateToken(tokenDescription);
            return tokenHandler.WriteToken(token);
        }
    }
}
