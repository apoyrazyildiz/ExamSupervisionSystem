using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Features.Commands
{
    internal class UpdateUserCommand
    {
        public int UserId { get; set; }

        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<int> RoleIds { get; set; } 
        public bool IsSuccessful { get; set; }
    }
}
