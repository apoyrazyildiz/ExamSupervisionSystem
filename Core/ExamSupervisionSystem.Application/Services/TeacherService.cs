using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Services
{
    internal class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public Task<int> CreateTeacherAsync(TeacherDto teacherDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTeacherAsync(int teacherId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TeacherDto>> GetAllTeachersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TeacherDto> GetTeacherByIdAsync(int teacherId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTeacherAsync(int teacherId, TeacherDto teacherDto)
        {
            throw new NotImplementedException();
        }
    }
}
