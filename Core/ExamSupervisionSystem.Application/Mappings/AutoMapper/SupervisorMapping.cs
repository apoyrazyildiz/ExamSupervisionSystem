using AutoMapper;
using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    internal class SupervisorMapping : Profile
    {
        public SupervisorMapping()
        {
            CreateMap<Supervisor, SupervisorDto>();


        }
    }
}
