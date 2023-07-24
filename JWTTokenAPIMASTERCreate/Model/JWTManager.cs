using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

namespace JWTTokenAPIMASTERCreate.Model
{
    public class JWTManager : IJWTManager
    {
        private readonly IConfiguration _configuration;
        public JWTManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetToken(string username, string password)
        {
            var key = _configuration.GetValue<string>("JWTConfiguration:key");
            var keybytes = Encoding.ASCII.GetBytes(key);
            var tokenhandler = new JwtSecurityTokenHandler();
            var tokendescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.NameIdentifier, username)

                }), Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials=new SigningCredentials(new SymmetricSecurityKey(keybytes),SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenhandler.CreateToken(tokendescriptor);
            return tokenhandler.WriteToken(token);
        }
    }
}
