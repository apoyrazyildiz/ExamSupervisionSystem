using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal class AdminRepository : IAdminRepository
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
    }
}
