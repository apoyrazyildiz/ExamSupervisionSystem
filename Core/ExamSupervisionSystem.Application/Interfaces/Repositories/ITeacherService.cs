using ExamSupervisionSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal interface ITeacherService
    {
        Task<TeacherDto> GetTeacherByIdAsync(int teacherId);
        Task<IEnumerable<TeacherDto>> GetAllTeachersAsync();
        Task<int> CreateTeacherAsync(TeacherDto teacherDto);
        Task<bool> UpdateTeacherAsync(int teacherId, TeacherDto teacherDto);
        Task<bool> DeleteTeacherAsync(int teacherId);
    }
}
