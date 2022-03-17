using Application.Common.Interfaces;
using Application.Common.Settings;
using Domain.Entities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Services;
public class TokenService : ITokenService
{


    private readonly string _signingKey;

    public TokenService(
        IOptionsMonitor<ApplicationJwtSettings> applicationJwtSettings)
    {
        _signingKey = applicationJwtSettings.CurrentValue.SigningKey;

    }

    public string GenerateJwtToken(AppUser user, List<Claim> claims)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_signingKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                }.Union(claims)
                ),

                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            //return tokenHandler.WriteToken(token);
            return tokenHandler.WriteToken(token);

        }
        catch (Exception e)
        {
            throw;
        }
    }
}