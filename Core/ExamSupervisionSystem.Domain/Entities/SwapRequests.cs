using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Domain.Entities
{
    internal class SwapRequests
    {
        public int Id { get; set; } 
        public int StudentId { get; set; } 
        public int CourseIdFrom { get; set; } 
        public int CourseIdTo { get; set; } 
        public DateTime RequestDate { get; set; } 
        public bool IsApproved { get; set; } 
    }
}
