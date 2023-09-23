using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Features.Commands
{
    internal class DeleteExamCommand
    {
        public int ExamId { get; set; }

        public bool IsSuccessful { get; set; }
    }
}
