using System.Collections.Generic;
using System.Threading.Tasks;
using ExamSupervisionSystem.Domain.Entities;
namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    public interface ISwapRequestRepository
    {
        Task<SwapRequest> GetSwapRequestByIdAsync(int swapRequestId);
        Task<List<SwapRequest>> GetAllSwapRequestsAsync();
        Task AddSwapRequestAsync(SwapRequest swapRequest);
        Task UpdateSwapRequestAsync(SwapRequest swapRequest);
        Task DeleteSwapRequestAsync(int swapRequestId);
    }
}