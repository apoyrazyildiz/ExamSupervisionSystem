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
    internal class SearchExamsQuery : IRequest<List<ExamDto>>
    {
        public string SearchKeyword { get; set; }

        public class SearchExamsQueryHandler : IRequestHandler<SearchExamsQuery, List<ExamDto>>
        {
            private readonly IExamRepository _examRepository;

            public SearchExamsQueryHandler(IExamRepository examRepository)
            {
                _examRepository = examRepository;
            }

            public async Task<List<ExamDto>> Handle(SearchExamsQuery request, CancellationToken cancellationToken)
            {
                // Veritabanından belirli bir anahtar kelimeye göre sınavları arayın
                var exams = await _examRepository.SearchExamsAsync(request.SearchKeyword);

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
