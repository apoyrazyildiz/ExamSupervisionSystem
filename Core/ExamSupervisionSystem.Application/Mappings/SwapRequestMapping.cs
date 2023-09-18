using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Mappings
{
    internal class SwapRequestMapping
    {
        public class SwapRequestMapping
        {
            public int RequesterId { get; set; } 
            public int ExamIdToGive { get; set; } 
            public int ExamIdToReceive { get; set; } 
            public DateTime RequestDate { get; set; } 
        }
    }
}
