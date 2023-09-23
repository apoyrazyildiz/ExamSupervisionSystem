using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSupervisionSystem.Application.Dtos;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal interface IExamService
    {
        Task<ExamDto> GetExamByIdAsync(int examId);
        Task<List<ExamDto>> GetAllExamsAsync();
        Task<int> CreateExamAsync(ExamDto examDto);
        Task UpdateExamAsync(int examId, ExamDto examDto);
        Task DeleteExamAsync(int examId);
    }
}
