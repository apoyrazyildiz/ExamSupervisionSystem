using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Domain.Entities
{
    internal class Supervisor
    {
        public int SupervisorId { get; set; }
        public string SupervisorName { get; set; }
        public string SupervisorSurname { get; set; }
        public string SupervisorFreeTime { get; set; }

    }
}
