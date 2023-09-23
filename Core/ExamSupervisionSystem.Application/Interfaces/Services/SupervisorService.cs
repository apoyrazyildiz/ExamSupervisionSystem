using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Application.Interfaces.Repositories;
using ExamSupervisionSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Services
{
    internal class SupervisorService : ISupervisorService
    {
        private readonly ISupervisorRepository _supervisorRepository;

        public SupervisorService(ISupervisorRepository supervisorRepository)
        {
            _supervisorRepository = supervisorRepository;
        }

        public IEnumerable<Supervisor> GetAllSupervisors()
        {
            // Tüm gözetmenleri veritabanından al
            return _supervisorRepository.GetAllSupervisors();
        }

        public Supervisor GetSupervisorById(int id)
        {
            // Belirli bir gözetmeni kimliğine göre al
            return _supervisorRepository.GetSupervisorById(id);
        }

        public void CreateSupervisor(Supervisor supervisor)
        {
            // Yeni bir gözetmen oluştur
            _supervisorRepository.AddSupervisor(supervisor);
            _supervisorRepository.Save();
        }

        public void UpdateSupervisor(Supervisor supervisor)
        {
            // Bir gözetmeni güncelle
            _supervisorRepository.UpdateSupervisor(supervisor);
            _supervisorRepository.Save();
        }

        public void DeleteSupervisor(int id)
        {
            // Bir gözetmeni sil
            _supervisorRepository.DeleteSupervisor(id);
            _supervisorRepository.Save();
        }

        public Task<SupervisorDto> GetSupervisorByIdAsync(int supervisorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SupervisorDto>> GetAllSupervisorsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateSupervisorAsync(SupervisorDto supervisorDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSupervisorAsync(int supervisorId, SupervisorDto supervisorDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSupervisorAsync(int supervisorId)
        {
            throw new NotImplementedException();
        }
    }
}
