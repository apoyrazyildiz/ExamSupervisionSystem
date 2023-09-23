using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Services
{
    internal class ExamService: IExamService
    {
        private readonly IExamRepository _examRepository;

        public ExamService(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }

        public Task<int> CreateExamAsync(ExamDto examDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteExamAsync(int examId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ExamDto>> GetAllExamsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ExamDto> GetExamByIdAsync(int examId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateExamAsync(int examId, ExamDto examDto)
        {
            throw new NotImplementedException();
        }
    }
}
