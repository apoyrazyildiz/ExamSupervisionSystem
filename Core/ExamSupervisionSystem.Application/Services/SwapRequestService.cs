using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Services
{
    internal class SwapRequestService : ISwapRequestService
    {
        private readonly ISwapRequestRepository _swapRequestRepository;

        public SwapRequestService(ISwapRequestRepository swapRequestRepository)
        {
            _swapRequestRepository = swapRequestRepository;
        }

        public Task<bool> ApproveSwapRequestAsync(int swapRequestId)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateSwapRequestAsync(SwapRequestDto swapRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSwapRequestAsync(int swapRequestId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SwapRequestDto>> GetAllSwapRequestsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SwapRequestDto> GetSwapRequestByIdAsync(int swapRequestId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSwapRequestAsync(int swapRequestId, SwapRequestDto swapRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
