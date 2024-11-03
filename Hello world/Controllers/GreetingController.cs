using Microsoft.AspNetCore.Mvc;
using Hello_world.Services;

namespace Hello_world.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase
    {
        private readonly GreetingService _greetingService;

        public GreetingController(GreetingService greetingService)
        {
            _greetingService = greetingService ?? throw new ArgumentNullException(nameof(greetingService));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var message = _greetingService.GetGreetingMessage();

            return Content(message);
        }
    }
}
