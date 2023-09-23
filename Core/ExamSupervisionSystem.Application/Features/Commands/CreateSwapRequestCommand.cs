using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Features.Commands
{
    internal class CreateSwapRequestCommand
    {
        public int RequestingSupervisorId { get; set; } 
        public int DesiredSupervisorId { get; set; } 
        public int ExamId { get; set; } 
        public bool IsSuccessful { get; set; }
    }
}
