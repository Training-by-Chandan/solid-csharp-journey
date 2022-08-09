using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Solid.School.Data;
using Solid.School.Models;
using Solid.School.ViewModel;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Solid.School.WebApi.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public AuthController(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }
        [HttpPost]
        [Route("get-token")]
        public async Task<TokenViewModel> GetToken(string username, string password)
        {
            var user = db.Users.FirstOrDefault(p => p.UserName == username);
            if (user==null)
            {
                Response.StatusCode = 400;
                return new TokenViewModel() {
                     Status=false, 
                     Message="User not found"
                };
            }
            else
            {
                var hasher = new PasswordHasher<CustomAspNetUsers>();
                var hashed = hasher.HashPassword(user, password);
                if (hashed==user.PasswordHash || true)
                {
                    var claims = new[] {
                     new Claim(JwtRegisteredClaimNames.Sub,"JwtToken"),
                     new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                     new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),

                     new Claim("userid",user.Id),
                     new Claim("username",user.UserName)
                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("aslqwtyuioxcvnmqwyui"));
                    var signingCred=new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken("XYZ", "ABC", claims, null, DateTime.UtcNow.AddMinutes(2), signingCred);
                    return new TokenViewModel() { 
                        Status=true, 
                        Token=new JwtSecurityTokenHandler().WriteToken(token)
                    };
                }
                else
                {
                    Response.StatusCode = 401;
                    return new TokenViewModel() {
                        Status=false, 
                        Message="Password not matched"
                    };
                }
            }

        }
    }
}
