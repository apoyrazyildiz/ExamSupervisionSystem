using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Features.Commands
{
    internal class UpdateExamCommand
    {
        public int ExamId { get; set; }

        
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }
        
        public bool IsSuccessful { get; set; }
    }
}
