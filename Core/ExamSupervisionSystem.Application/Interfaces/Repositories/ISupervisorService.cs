using ExamSupervisionSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    public interface ISupervisorService
    {
        Task<SupervisorDto> GetSupervisorByIdAsync(int supervisorId);
        Task<IEnumerable<SupervisorDto>> GetAllSupervisorsAsync();
        Task<int> CreateSupervisorAsync(SupervisorDto supervisorDto);
        Task<bool> UpdateSupervisorAsync(int supervisorId, SupervisorDto supervisorDto);
        Task<bool> DeleteSupervisorAsync(int supervisorId);
    }
}
