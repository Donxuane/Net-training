using FirstWebApIWithAuthorization.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FirstWebApIWithAuthorization.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly JwtAuth _jwtAuth;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, JwtAuth jwtAuth)
        {
            _logger = logger;
            _jwtAuth = jwtAuth;
        }
        [Authorize]
        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            return Ok(new { User.Identity.Name, User.FindFirst(System.Security.Claims.ClaimTypes.Sid).Value });
        }

        [HttpGet("generateToken")]
        public ActionResult<string> GetToken(int userId, string userName)
        {
            
            var token = _jwtAuth.GenerateToken(userId, userName);
            Response.Cookies.Append("AccessToken", token);
            return token;
        }
    }
}
