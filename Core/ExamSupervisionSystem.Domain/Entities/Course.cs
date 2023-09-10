using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Domain.Entities
{
    internal class Course
    {
        public int Id { get; set; }

        
        public string Name { get; set; }

        
        public string Code { get; set; }

        
        public string Description { get; set; }

       
        public int TeacherId { get; set; }

        
        public DateTime StartDate { get; set; }

        
        public DateTime EndDate { get; set; }
    }
}
