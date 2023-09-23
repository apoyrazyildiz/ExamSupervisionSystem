using AutoMapper.Internal;
using ExamSupervisionSystem.Application.Interfaces.Repositories;
using ExamSupervisionSystem.Domain.Entities;
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

        public IEnumerable<SwapRequests> GetAllSwapRequests()
        {
            return _swapRequestRepository.GetAllSwapRequests();
        }

        public SwapRequests GetSwapRequestById(int id)
        {
            return _swapRequestRepository.GetSwapRequestById(id);
        }

        public void CreateSwapRequest(SwapRequests request)
        {
            _swapRequestRepository.AddSwapRequest(request);
            _swapRequestRepository.Save();
        }

        public void UpdateSwapRequest(SwapRequests request)
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
