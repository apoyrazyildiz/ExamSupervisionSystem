using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Application.Interfaces.Repositories;
using ExamSupervisionSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Services
{
    internal class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        private object _unitOfWork;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public async Task<int> CreateAdminAsync(AdminDto adminDto)
        {
            if (adminDto == null)
            {
                throw new ArgumentNullException(nameof(adminDto));
            }

            
            var admin = new Admin
            {
                FirstName = adminDto.FirstName,
                LastName = adminDto.LastName,
                Email = adminDto.Email,
                
            };

            
            _adminRepository.AddAdmin(admin);

           
            await _unitOfWork.SaveChangesAsync();

            return admin.AdminId;
        }

        public Task DeleteAdminAsync(int adminId)
        {
            throw new NotImplementedException();
        }

        public Task<AdminDto> GetAdminByIdAsync(int adminId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AdminDto>> GetAllAdminsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAdminAsync(AdminDto adminDto)
        {
            throw new NotImplementedException();
        }
    }
}
