using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Domain.Entities;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal interface IExamRepository
    {
        Task<ExamDto> GetExamByIdAsync(int examId);
        Task<IEnumerable<ExamDto>> GetAllExamsAsync();
        Task<int> CreateExamAsync(ExamDto examDto);
        Task<bool> UpdateExamAsync(int examId, ExamDto examDto);
        Task<bool> DeleteExamAsync(int examId);
        Task<IEnumerable<Exam>> SortExamsByDateAscendingAsync();
        Task<IEnumerable<Exam>> SortExamsByDateDescendingAsync();
        Task<IEnumerable<Exam>> GetExamsBySupervisorAsync(int supervisorId);
        Task GetByIdAsync(int examId);
        Task<IEnumerable<Exam>> SearchExamsAsync(string searchKeyword);
    }
}