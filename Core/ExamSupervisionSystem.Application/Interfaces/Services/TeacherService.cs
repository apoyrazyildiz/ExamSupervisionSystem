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
    internal class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        private object _mapper;

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

        public async Task<TeacherDto> GetTeacherByIdAsync(int teacherId)
        {
            var teacher = await _teacherRepository.GetTeacherByIdAsync(teacherId);

            if (teacher == null)
            {
                // Öğretmen bulunamadı, uygun bir hata işlemi yapabilirsiniz.
                throw new Exception("Öğretmen bulunamadı");
            }

            // Öğretmeni TeacherDto'ya dönüştürün. AutoMapper veya benzeri bir araç kullanabilirsiniz.
            var teacherDto = _mapper.Map<TeacherDto>(teacher);

            return teacherDto;
        }

        public Task<IEnumerable<TeacherDto>> GetAllTeachersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateTeacherAsync(TeacherDto teacherDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateTeacherAsync(int teacherId, TeacherDto teacherDto)
        {
            var existingTeacher = await _teacherRepository.GetTeacherByIdAsync(teacherId);

            if (existingTeacher == null)
            {
                
                throw new Exception("Öğretmen bulunamadı");
            }

            
            existingTeacher.Name = teacherDto.Name;
            existingTeacher.Email = teacherDto.Email;
            existingTeacher.PhoneNumber = teacherDto.PhoneNumber;

            
            await _teacherRepository.UpdateTeacherAsync(existingTeacher);

            return true;
        }

        public async Task<bool> DeleteTeacherAsync(int teacherId)
        {
            var teacher = await _teacherRepository.GetTeacherByIdAsync(teacherId);

            if (teacher == null)
            {
                
                throw new Exception("Öğretmen bulunamadı");
            }

            // Öğretmeni veritabanından silin.
            await _teacherRepository.DeleteTeacherAsync(teacher);

            // Silme işlemi başarılı olduysa true döndürün.
            return true;
        }
    }
}
