using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Features.Commands
{
    internal class SwapTeacherCourseCommand
    {
        public int FirstTeacherId { get; set; } 
        public int SecondTeacherId { get; set; } 
        public int CourseId { get; set; } 
        public bool IsSuccessful { get; set; }
    }
}
