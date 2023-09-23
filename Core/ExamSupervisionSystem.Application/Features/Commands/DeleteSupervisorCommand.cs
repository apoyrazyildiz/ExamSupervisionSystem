using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Features.Commands
{
    internal class DeleteSupervisorCommand
    {
        public int SupervisorId { get; set; }

        // Silme işleminin başarıyla tamamlandığını belirten bayrak.
        public bool IsSuccessful { get; set; }
    }
}
