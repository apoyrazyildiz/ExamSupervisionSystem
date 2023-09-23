using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Domain.Entities;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal class TeacherRepostiory : ITeacherRepository
    {
        private readonly ApplicationDbContext _context;

        public object EntityState { get; private set; }

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

        public async Task<TeacherDto> GetTeacherByIdAsync(int teacherId)
        {
            var teacher = await _context.Teachers.SingleOrDefaultAsync(t => t.TeacherId == teacherId);

            

            if (teacher == null)
            {
                return null;
            }

            
            var teacherDto = new TeacherDto
            {
                TeacherId = teacher.TeacherId,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
               
            };

            return teacherDto;
        }



        public async Task<IEnumerable<TeacherDto>> GetAllTeachersAsync()
        {
        var teachers = await _context.Teachers.ToListAsync();

        
        var teacherDtos = teachers.Select(teacher => new TeacherDto
        {
            TeacherId = teacher.TeacherId,
            FirstName = teacher.FirstName,
            LastName = teacher.LastName,
            
        });

        return teacherDtos;
    }
}

       
}
