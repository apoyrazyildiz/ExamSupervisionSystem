using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal interface ISupervisorRepository
    {
        Task<SupervisorDto> GetSupervisorByIdAsync(int supervisorId);
        Task<IEnumerable<SupervisorDto>> GetAllSupervisorsAsync();
        Task<int> CreateSupervisorAsync(SupervisorDto supervisorDto);
        Task<bool> UpdateSupervisorAsync(int supervisorId, SupervisorDto supervisorDto);
        Task<bool> DeleteSupervisorAsync(int supervisorId);
        IEnumerable<Supervisor> GetAllSupervisors();
        Supervisor GetSupervisorById(int id);
        void AddSupervisor(Supervisor supervisor);
        void Save();
        void UpdateSupervisor(Supervisor supervisor);
        void DeleteSupervisor(int id);
        Task GetByIdAsync(int supervisorId);
    }
}
