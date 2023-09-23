using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Services
{
    internal class CourseService:ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<CourseDto> GetCourseByIdAsync(int courseId)
        {
            var course = await _courseRepository.GetCourseByIdAsync(courseId);
            return course;
        }

        public async Task<IEnumerable<CourseDto>> GetAllCoursesAsync()
        {
            var courses = await _courseRepository.GetAllCoursesAsync();
            return courses;
        }

        public async Task<int> CreateCourseAsync(CourseDto courseDto)
        {
            var courseId = await _courseRepository.CreateCourseAsync(courseDto);
            return courseId;
        }

        public async Task<bool> UpdateCourseAsync(int courseId, CourseDto courseDto)
        {
            return await _courseRepository.UpdateCourseAsync(courseId, courseDto);
        }

        public async Task<bool> DeleteCourseAsync(int courseId)
        {
            return await _courseRepository.DeleteCourseAsync(courseId);
        }
    }
}
