using MediatR;
using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Application.Interfaces.Repositories;

namespace ExamSupervisionSystem.Application.Features.Queries.GetExamDetails
{
    public class GetExamDetailsQueryHandler : IRequestHandler<GetExamDetailsQuery, ExamDto>
    {
        private readonly IExamRepository _examRepository;

        public GetExamDetailsQueryHandler(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }

        public async Task<ExamDto> Handle(GetExamDetailsQuery request, CancellationToken cancellationToken)
        {
            // Belirli bir sınavın kimlik numarasına göre sınavı alın
            var exam = await _examRepository.GetByIdAsync(request.ExamId);
            if (exam == null)
            {
                throw new NotFoundException("Sınav bulunamadı");
            }

            // Sınavı ExamDto nesnesine dönüştürün
            var examDto = new ExamDto
            {
                // ExamDto nesnesinin özelliklerini doldurun
                Id = exam.Id,
                // Diğer özellikler burada doldurulur
            };

            return examDto;
        }
    }
}
