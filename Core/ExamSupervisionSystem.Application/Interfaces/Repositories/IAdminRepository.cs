using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExamSupervisionSystem.Domain.Entities;
namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    public interface IAdminRepository
    {
        Task<Admin> GetAdminByIdAsync(int adminId);
        Task<List<Admin>> GetAllAdminsAsync();
        Task AddAdminAsync(Admin admin);
        Task UpdateAdminAsync(Admin admin);
        Task DeleteAdminAsync(int adminId);
        void AddAdmin(Admin admin);
    }
}