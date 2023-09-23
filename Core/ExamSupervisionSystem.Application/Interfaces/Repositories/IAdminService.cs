using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Domain.Entities;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    public interface IAdminService
    {
        Task<AdminDto> GetAdminByIdAsync(int adminId);
        Task<IEnumerable<AdminDto>> GetAllAdminsAsync();
        Task<int> CreateAdminAsync(AdminDto adminDto);
        Task UpdateAdminAsync(AdminDto adminDto);
        Task DeleteAdminAsync(int adminId);
    }
}
