using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToDo_Auth.Authorization;

namespace ToDo_Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtTokenGenerator _jwtTokenGenerator = new JwtTokenGenerator();

        [HttpGet]
        [Route("generate-token")]
        public IActionResult GenerateToken()
        {
            var jwt = _jwtTokenGenerator.Generate("1");
            return Ok(jwt);
        }

        [HttpGet]
        [Route("test")]
        [Authorize("MyApiUserPolicy", AuthenticationSchemes = "Bearer")]
        public IActionResult Test()
        {
            return Ok("ok");
        }
    }
}
