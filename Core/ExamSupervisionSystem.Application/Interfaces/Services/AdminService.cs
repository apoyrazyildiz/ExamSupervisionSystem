using ExamSupervisionSystem.Application.Interfaces.Repositories;
using ExamSupervisionSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Services
{
    internal class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public IEnumerable<Admin> GetAllAdmins()
        {
            // Tüm admin kullanıcılarını veritabanından al
            return _adminRepository.GetAllAdmins();
        }

        public Admin GetAdminById(int id)
        {
            // Belirli bir admin kullanıcısını kimliğine göre al
            return _adminRepository.GetAdminById(id);
        }

        public void CreateAdmin(Admin admin)
        {
            // Yeni bir admin kullanıcısı oluştur
            _adminRepository.AddAdmin(admin);
            _adminRepository.Save();
        }

        public void UpdateAdmin(Admin admin)
        {
            // Bir admin kullanıcısını güncelle
            _adminRepository.UpdateAdmin(admin);
            _adminRepository.Save();
        }

        public void DeleteAdmin(int id)
        {
            // Bir admin kullanıcısını sil
            _adminRepository.DeleteAdmin(id);
            _adminRepository.Save();
        }
    }
}
