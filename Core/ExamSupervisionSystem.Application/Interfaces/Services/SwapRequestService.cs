using AutoMapper.Internal;
using ExamSupervisionSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Services
{
    internal class SwapRequestService
    {
        private readonly ISwapRequestRepository _swapRequestRepository;

        public SwapRequestService(ISwapRequestRepository swapRequestRepository)
        {
            _swapRequestRepository = swapRequestRepository;
        }

        public IEnumerable<SwapRequest> GetAllSwapRequests()
        {
            return _swapRequestRepository.GetAllSwapRequests();
        }

        public SwapRequest GetSwapRequestById(int id)
        {
            return _swapRequestRepository.GetSwapRequestById(id);
        }

        public void CreateSwapRequest(SwapRequest request)
        {
            _swapRequestRepository.AddSwapRequest(request);
            _swapRequestRepository.Save();
        }

        public void UpdateSwapRequest(SwapRequest request)
        {
            _swapRequestRepository.UpdateSwapRequest(request);
            _swapRequestRepository.Save();
        }

        public void DeleteSwapRequest(int id)
        {
            _swapRequestRepository.DeleteSwapRequest(id);
            _swapRequestRepository.Save();
        }
    }
}
