﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.Internal;


namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal class SwapRequestRepository : ISwapRequestRepository
    {
        private readonly ApplicationDbContext _context;

        public SwapRequestRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SwapRequest> GetAllSwapRequests()
        {
            return _context.SwapRequests.ToList();
        }

        public SwapRequest GetSwapRequestById(int id)
        {
            return _context.SwapRequests.FirstOrDefault(request => request.Id == id);
        }

        public void AddSwapRequest(SwapRequest request)
        {
            _context.SwapRequests.Add(request);
        }

        public void UpdateSwapRequest(SwapRequest request)
        {
            _context.Entry(request).State = EntityState.Modified;
        }

        public void DeleteSwapRequest(int id)
        {
            var requestToDelete = _context.SwapRequests.Find(id);
            if (requestToDelete != null)
            {
                _context.SwapRequests.Remove(requestToDelete);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}