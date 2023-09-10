using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(course => course.Id == id);
        }

        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
        }

        public void UpdateCourse(Course course)
        {
            _context.Entry(course).State = EntityState.Modified;
        }

        public void DeleteCourse(int id)
        {
            var courseToDelete = _context.Courses.Find(id);
            if (courseToDelete != null)
            {
                _context.Courses.Remove(courseToDelete);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
