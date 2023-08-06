using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareSpokes.FamilyManager.Application.CommandHandlers
{
    public class SubscribeToCalendarCommand : IRequest
    {
        public string CalendarName { get; set; }

        public SubscribeToCalendarCommand(string calendarName)
        {
            if (string.IsNullOrWhiteSpace(calendarName))
            {
                throw new ArgumentNullException(nameof(calendarName));
            }

            CalendarName = calendarName;
        }
    }

    internal class SubscribeToCalendarHandler : IRequestHandler<SubscribeToCalendarCommand>
    {
        
        public Task Handle(SubscribeToCalendarCommand request, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
