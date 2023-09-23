using System.Threading.Tasks;
using ExamSupervisionSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using ExamSupervisionSystem.Domain.Entities;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext _context;

        public AdminRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Admin> GetAllAdmins()
        {
            return _context.Admins.ToList();
        }

        public Admin GetAdminById(int id)
        {
            return _context.Admins.FirstOrDefault(admin => admin.Id == id);
        }

        public void AddAdmin(Admin admin)
        {
            _context.Admins.Add(admin);
        }

        public void UpdateAdmin(Admin admin)
        {
            _context.Entry(admin).State = EntityState.Modified;
        }

        public void DeleteAdmin(int id)
        {
            var adminToDelete = _context.Admins.Find(id);
            if (adminToDelete != null)
            {
                _context.Admins.Remove(adminToDelete);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task<Admin> GetAdminByIdAsync(int adminId)
        {
            var admin = await _context.Admins.SingleOrDefaultAsync(a => a.AdminId == adminId);
            return admin;
        }

        public async Task<List<Admin>> GetAllAdminsAsync()
        {
            var admins = await _context.Admins.ToListAsync();

        return admins;
        }

        async Task<Admin> IAdminRepository.GetAdminByIdAsync(int adminId)
        {
            var admin = await _context.Admins.SingleOrDefaultAsync(a => a.AdminId == adminId);
            return admin;
        }

        Task<List<Admin>> IAdminRepository.GetAllAdminsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task AddAdminAsync(Admin admin)
        {
            _context.Admins.Add(admin);

            
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAdminAsync(Admin admin)
        {
            _context.Entry(admin).State = EntityState.Modified;

          
            await _context.SaveChangesAsync();
        }

        public Task DeleteAdminAsync(int adminId)
        {
            throw new NotImplementedException();
        }
    }
}

