using AutoMapper;
using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Application.Interfaces.Services;
using ExamSupervisionSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    internal class ExamMapping : Profile
    {
        public ExamMapping()
        {
            CreateMap<Exam, ExamDto>();

        }
    }
}
