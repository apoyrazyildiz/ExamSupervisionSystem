using ExamSupervisionSystem.Application.Interfaces.Repositories;
using ExamSupervisionSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Services
{
    internal class CourseService: ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            // Tüm dersleri veritabanından al
            return _courseRepository.GetAllCourses();
        }

        public Course GetCourseById(int id)
        {
            // Belirli bir dersi kimliğine göre al
            return _courseRepository.GetCourseById(id);
        }

        public void CreateCourse(Course course)
        {
            // Yeni bir ders oluştur
            _courseRepository.AddCourse(course);
            _courseRepository.Save();
        }

        public void UpdateCourse(Course course)
        {
            // Bir dersi güncelle
            _courseRepository.UpdateCourse(course);
            _courseRepository.Save();
        }

        public void DeleteCourse(int id)
        {
            // Bir dersi sil
            _courseRepository.DeleteCourse(id);
            _courseRepository.Save();
        }

    }
}
