using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Dtos
{
    internal class SwapRequestDto
    {
        public int SwapRequestId { get; set; }
        public int RequestingTeacherId { get; set; }
        public int TargetTeacherId { get; set; }
        public int ExamId { get; set; }
        public bool IsApproved { get; set; }
    }
}
