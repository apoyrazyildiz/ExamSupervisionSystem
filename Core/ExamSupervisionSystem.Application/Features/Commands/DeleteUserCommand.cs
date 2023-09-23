using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Features.Commands
{
    internal class DeleteUserCommand
    {
        public int UserId { get; set; }

        
        public bool IsSuccessful { get; set; }
    }
}
