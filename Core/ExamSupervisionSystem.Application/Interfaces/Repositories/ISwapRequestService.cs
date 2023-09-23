using ExamSupervisionSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal interface ISwapRequestService
    {
        Task<SwapRequestDto> GetSwapRequestByIdAsync(int swapRequestId);
        Task<IEnumerable<SwapRequestDto>> GetAllSwapRequestsAsync();
        Task<int> CreateSwapRequestAsync(SwapRequestDto swapRequestDto);
        Task<bool> UpdateSwapRequestAsync(int swapRequestId, SwapRequestDto swapRequestDto);
        Task<bool> DeleteSwapRequestAsync(int swapRequestId);
        Task<bool> ApproveSwapRequestAsync(int swapRequestId);
    }
}
