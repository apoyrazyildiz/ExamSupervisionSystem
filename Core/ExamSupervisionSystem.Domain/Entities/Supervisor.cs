using ExamSupervisionSystem.Application.Interfaces.Repositories;
using ExamSupervisionSystem.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Domain.Entities
{
    public class Supervisor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<TimeSlot> AvailableTimeSlots { get; set; } // Gözetmenin uygun saatleri.
        public List<TimeSlot> BusyTimeSlots { get; set; } // Gözetmenin meşgul saatleri.

    }
}
