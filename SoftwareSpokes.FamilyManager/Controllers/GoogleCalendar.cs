using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SoftwareSpokes.FamilyManager.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoogleCalendar : ControllerBase
    {
        private readonly IMediator _mediator;

        public GoogleCalendar(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("subscribe")]
        public async Task SubscribeToCalendar(
            [FromBody][Required(AllowEmptyStrings = false)]string calendarName
        )
        {
            
        }

    }
}
