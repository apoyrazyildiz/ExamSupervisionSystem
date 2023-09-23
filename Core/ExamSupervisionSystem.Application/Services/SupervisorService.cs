using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Services
{
    internal class SupervisorService : ISupervisorService
    {
        private readonly ISupervisorRepository _supervisorRepository;

        public SupervisorService(ISupervisorRepository supervisorRepository)
        {
            _supervisorRepository = supervisorRepository;
        }

        public async Task<SupervisorDto> GetSupervisorByIdAsync(int supervisorId)
        {
            var supervisor = await _supervisorRepository.GetSupervisorByIdAsync(supervisorId);
            return supervisor;
        }

        public async Task<IEnumerable<SupervisorDto>> GetAllSupervisorsAsync()
        {
            var supervisors = await _supervisorRepository.GetAllSupervisorsAsync();
            return supervisors;
        }

        public async Task<int> CreateSupervisorAsync(SupervisorDto supervisorDto)
        {
            var supervisorId = await _supervisorRepository.CreateSupervisorAsync(supervisorDto);
            return supervisorId;
        }

        public async Task<bool> UpdateSupervisorAsync(int supervisorId, SupervisorDto supervisorDto)
        {
            return await _supervisorRepository.UpdateSupervisorAsync(supervisorId, supervisorDto);
        }

        public async Task<bool> DeleteSupervisorAsync(int supervisorId)
        {
            return await _supervisorRepository.DeleteSupervisorAsync(supervisorId);
        }
    }
}
