using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ExamSupervisionSystem.Application.Dtos;

namespace ExamSupervisionSystem.Application.Features.Queries.GetExamDetails
{
    public class GetExamDetailsQuery : IRequest<ExamDto>
    {
        public int ExamId { get; set; }


    }
}
