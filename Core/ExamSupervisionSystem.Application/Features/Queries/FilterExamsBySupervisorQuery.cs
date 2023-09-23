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
    internal class FilterExamsBySupervisorQuery : IRequest<List<ExamDto>>
    {
        public int SupervisorId { get; set; }

        public class FilterExamsBySupervisorQueryHandler : IRequestHandler<FilterExamsBySupervisorQuery, List<ExamDto>>
        {
            private readonly ISupervisorRepository _supervisorRepository;
            private readonly IExamRepository _examRepository;

            public FilterExamsBySupervisorQueryHandler(ISupervisorRepository supervisorRepository, IExamRepository examRepository)
            {
                _supervisorRepository = supervisorRepository;
                _examRepository = examRepository;
            }

            public async Task<List<ExamDto>> Handle(FilterExamsBySupervisorQuery request, CancellationToken cancellationToken)
            {
                // Gözetmenin kimlik numarasına göre gözetmeni alın
                var supervisor = await _supervisorRepository.GetByIdAsync(request.SupervisorId);
                if (supervisor == null)
                {
                    throw new NotFoundException("Gözetmen bulunamadı");
                }

                // Gözetmenin atanmış olduğu sınavları alın
                var exams = await _examRepository.GetExamsBySupervisorAsync(request.SupervisorId);

                // Sınavları ExamDto nesnelerine dönüştürün
                var examDtos = exams.Select(exam => new ExamDto
                {
                    // ExamDto nesnesinin özelliklerini doldurun
                    Id = exam.Id,
                    // Diğer özellikler burada doldurulur
                }).ToList();

                return examDtos;
            }
        }
    }
}
