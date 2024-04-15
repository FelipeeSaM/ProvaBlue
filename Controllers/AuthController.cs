using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProvaBlue.Db;
using ProvaBlue.Extensions;
using ProvaBlue.Models;

namespace ProvaBlue.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase {

        private readonly Prova_db_context _dbcontext;
        private readonly TokenService _tokenservice;

        public AuthController(Prova_db_context dbcontext, TokenService tokenservice) {
            _dbcontext = dbcontext;
            _tokenservice = tokenservice;
        }

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string IsAuthenticated() {
            return "Authenticated!";
        }

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "BlueEmployee")]
        public string IsEmployee() {
            return "É funcionário da Blue!";
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] UserModel user) {
            var userDb = await _dbcontext.Users.FirstOrDefaultAsync(c => c.UserName.Equals(user.UserName));

            if(userDb == null) return NotFound();

            //TokenService tokenObj = new TokenService();
            var token = _tokenservice.GenerateToken(userDb);

            user.Password = "";

            return new {
                user = user,
                token = token
            };
        }

    }
}
