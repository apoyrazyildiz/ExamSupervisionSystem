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
    internal class SortExamsByDateQuery : IRequest<List<ExamDto>>
    {
        public bool Ascending { get; set; }

        public class SortExamsByDateQueryHandler : IRequestHandler<SortExamsByDateQuery, List<ExamDto>>
        {
            private readonly IExamRepository _examRepository;

            public SortExamsByDateQueryHandler(IExamRepository examRepository)
            {
                _examRepository = examRepository;
            }

            public async Task<List<ExamDto>> Handle(SortExamsByDateQuery request, CancellationToken cancellationToken)
            {
                // Tarihe göre sınavları sıralayın (Artan veya Azalan olarak)
                var exams = request.Ascending
                    ? await _examRepository.SortExamsByDateAscendingAsync()
                    : await _examRepository.SortExamsByDateDescendingAsync();

                // Sınavları ExamDto nesnelerine dönüştürün
                var examDtos = exams.Select(exam => new ExamDto
                {
                    // ExamDto nesnesinin özelliklerini doldurun
                    Id = exam.Id
                    // Diğer özellikler burada doldurulur
                }).ToList();

                return examDtos;
            }
        }
    }
}
