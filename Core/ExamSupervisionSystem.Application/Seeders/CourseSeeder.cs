using ExamSupervisionSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Seeders
{
    internal class CourseSeeder
    {
        private readonly ApplicationDbContext _context;

        public CourseSeeder(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Courses.Any())
            {
                var courses = new List<Course>
            {
                new Course { Name = "Math", Description = "Mathematics course" },
                new Course { Name = "Science", Description = "Science course" },
                // Diğer dersler burada eklenir
            };

                _context.Courses.AddRange(courses);
                _context.SaveChanges();
            }
        }
    }
}
