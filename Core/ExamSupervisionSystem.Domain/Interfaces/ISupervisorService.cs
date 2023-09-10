using ExamSupervisionSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Domain.Interfaces
{
    internal interface ISupervisorService
    {
        Supervisor GetSupervisorById(int id);
        List<Supervisor> GetAllSupervisors();
        bool AssignSupervisor(int courseId, int supervisorId);
    }
}
