using FirstWebApIWithAuthorization.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FirstWebApIWithAuthorization.Services;

public class JwtAuth(IConfiguration configuration)
{
    public string GenerateToken(int userId, string userName)
    {
        var _config = configuration.GetSection("Jwt").Get<JwtConfigs>();
        var claims = new[]
        {
            new Claim(ClaimTypes.Sid, userId.ToString()),
            new Claim(ClaimTypes.Name,userName),
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.Key));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddHours(2),
            SigningCredentials = creds,
            Issuer = _config.ApplicationName,
            Audience = _config.Audience
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenModel = tokenHandler.CreateToken(token);
        return tokenHandler.WriteToken(tokenModel);
    }
}
