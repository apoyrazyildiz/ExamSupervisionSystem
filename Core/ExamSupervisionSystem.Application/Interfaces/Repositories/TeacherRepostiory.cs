using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSupervisionSystem.Application.Entities;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal class TeacherRepostiory : ITeacherRepository
    {
        private readonly ApplicationDbContext _context;

        public TeacherRepostiory(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetTeacherById(int id)
        {
            return _context.Teachers.FirstOrDefault(teacher => teacher.Id == id);
        }

        public void AddTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _context.Entry(teacher).State = EntityState.Modified;
        }

        public void DeleteTeacher(int id)
        {
            var teacherToDelete = _context.Teachers.Find(id);
            if (teacherToDelete != null)
            {
                _context.Teachers.Remove(teacherToDelete);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
