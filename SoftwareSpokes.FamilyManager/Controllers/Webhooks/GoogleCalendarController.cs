using Microsoft.AspNetCore.Mvc;

namespace SoftwareSpokes.FamilyManager.Api.Controllers.Webhooks
{
    [ApiController]
    [Route("[controller]")]
    public class GoogleCalendarController : ControllerBase
    {
        private readonly ILogger<GoogleCalendarController> _logger;

        public GoogleCalendarController(ILogger<GoogleCalendarController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IEnumerable<WeatherForecast> Get()
        {
            return Array.Empty<WeatherForecast>();
        }
    }
}
