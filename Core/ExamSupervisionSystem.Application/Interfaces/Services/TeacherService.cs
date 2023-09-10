using ExamSupervisionSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Services
{
    internal class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            // Tüm öğretmenleri veritabanından al
            return _teacherRepository.GetAllTeachers();
        }

        public Teacher GetTeacherById(int id)
        {
            // Belirli bir öğretmeni kimliğine göre al
            return _teacherRepository.GetTeacherById(id);
        }

        public void CreateTeacher(Teacher teacher)
        {
            // Yeni bir öğretmen oluştur
            _teacherRepository.AddTeacher(teacher);
            _teacherRepository.Save();
        }

        public void UpdateTeacher(Teacher teacher)
        {
            // Bir öğretmeni güncelle
            _teacherRepository.UpdateTeacher(teacher);
            _teacherRepository.Save();
        }

        public void DeleteTeacher(int id)
        {
            // Bir öğretmeni sil
            _teacherRepository.DeleteTeacher(id);
            _teacherRepository.Save();
        }
    }
}
