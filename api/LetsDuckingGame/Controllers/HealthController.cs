using Microsoft.AspNetCore.Mvc;

namespace LetsDuckingGame.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Service is healthy");
        }
    }
}
