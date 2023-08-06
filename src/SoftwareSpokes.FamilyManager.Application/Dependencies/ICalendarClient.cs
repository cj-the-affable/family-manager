using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareSpokes.FamilyManager.Application.Dependencies
{
    public interface ICalendarClient
    {
        Task SubscribeToCalendar();
    }
}
