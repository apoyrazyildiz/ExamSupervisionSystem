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
    internal class CalculateSupervisorWorkloadQuery: IRequest<int>
    {
        public int SupervisorId { get; set; }

        public class CalculateSupervisorWorkloadQueryHandler : IRequestHandler<CalculateSupervisorWorkloadQuery, int>
        {
            private readonly ISupervisorRepository _supervisorRepository;
            private readonly IExamRepository _examRepository;

            public CalculateSupervisorWorkloadQueryHandler(ISupervisorRepository supervisorRepository, IExamRepository examRepository)
            {
                _supervisorRepository = supervisorRepository;
                _examRepository = examRepository;
            }

            public async Task<int> Handle(CalculateSupervisorWorkloadQuery request, CancellationToken cancellationToken)
            {
                // Gözetmenin atanmış olduğu sınavları alın
                var supervisor = await _supervisorRepository.GetByIdAsync(request.SupervisorId);
                if (supervisor == null)
                {
                    throw new NotFoundException("Gözetmen bulunamadı");
                }

                // Gözetmenin atanmış olduğu sınavların toplam sayısını hesaplayın
                var workload = await _examRepository.GetSupervisorWorkloadAsync(request.SupervisorId);

                return workload;
            }
        }
    }
}
