using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Domain.Entities
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName   { get; set; }
       
       
        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }
        public string Email { get; set; }
    }
}
