using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using PRIORI_SERVICES_API.Shared;

namespace PRIORI_SERVICES_API.Repository;
public static class JwtHandler
{
    public static JwtSecurityToken GenerateJWTToken(IConfiguration configuration_context, List<Claim> claims, string jwt_key_attribute = "JWTKey")
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(EnvironmentVariables.PRIORI_SECRET_JWT_KEY));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        return new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(30),
                signingCredentials: creds
            );
    }
}
