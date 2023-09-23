using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal interface ITeacherRepository
    {
        Task<TeacherDto> GetTeacherByIdAsync(int teacherId);
        Task<IEnumerable<TeacherDto>> GetAllTeachersAsync();
        Task<int> CreateTeacherAsync(TeacherDto teacherDto);
        Task<bool> UpdateTeacherAsync(int teacherId, TeacherDto teacherDto);
        Task<bool> DeleteTeacherAsync(int teacherId);
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacherById(int id);
        void AddTeacher(Teacher teacher);
        void Save();
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int id);
        Task DeleteTeacherAsync(TeacherDto teacher);
        Task UpdateTeacherAsync(TeacherDto existingTeacher);
    }
}
