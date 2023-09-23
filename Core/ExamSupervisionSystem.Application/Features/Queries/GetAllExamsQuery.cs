using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ExamSupervisionSystem.Application.Dtos; 
using ExamSupervisionSystem.Application.Interfaces.Repositories; 

namespace ExamSupervisionSystem.Application.Features.Queries
{
    internal class GetAllExamsQuery : IRequest<List<ExamDto>>
    {
        public class GetAllExamsQueryHandler : IRequestHandler<GetAllExamsQuery, List<ExamDto>>
        {
            private readonly IExamRepository _examRepository;

            public GetAllExamsQueryHandler(IExamRepository examRepository)
            {
                _examRepository = examRepository;
            }

            public async Task<List<ExamDto>> Handle(GetAllExamsQuery request, CancellationToken cancellationToken)
            {
                
                var exams = await _examRepository.GetAllAsync();

                
                var examDtos = exams.Select(exam => new ExamDto
                {
                    
                    Id = exam.Id,
                    
                }).ToList();

                return examDtos;
            }
        }
    }
}
