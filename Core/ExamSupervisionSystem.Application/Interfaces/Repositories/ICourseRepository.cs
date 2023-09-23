using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Domain.Entities;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourses();
        Course GetCourseById(int id);
        void UpdateCourse(Course course);
        Task<bool> UpdateCourseAsync(int courseId, CourseDto courseDto);
    }
}