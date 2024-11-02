using Microsoft.AspNetCore.Mvc;
using Hello_world.Services;

namespace Hello_world.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase
    {
        private readonly GreetingService _greetingService;

        public GreetingController()
        {
            _greetingService = new GreetingService();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var message = _greetingService.GetGreetingMessage();
            return Ok(message);
        }
    }
}
