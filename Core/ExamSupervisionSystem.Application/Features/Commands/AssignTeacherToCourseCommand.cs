using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Features.Commands
{
    internal class AssignTeacherToCourseCommand
    {
        public int CourseId { get; set; } 
        public int TeacherId { get; set; } 
        public bool IsSuccessful { get; set; }
    }
}
