using ExamSupervisionSystem.Application.Dtos;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal interface IExamRepository
    {
        Task<ExamDto> GetExamByIdAsync(int examId);
        Task<IEnumerable<ExamDto>> GetAllExamsAsync();
        Task<int> CreateExamAsync(ExamDto examDto);
        Task<bool> UpdateExamAsync(int examId, ExamDto examDto);
        Task<bool> DeleteExamAsync(int examId);
        Task<IEnumerable<object>> SortExamsByDateAscendingAsync();
        Task<IEnumerable<object>> SortExamsByDateDescendingAsync();
        Task<IEnumerable<object>> GetExamsBySupervisorAsync(int supervisorId);
        Task GetByIdAsync(int examId);
        Task<IEnumerable<object>> SearchExamsAsync(string searchKeyword);
    }
}