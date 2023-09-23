using AutoMapper;
using ExamSupervisionSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    internal class LoadMapping : Profile
    {
        public LoadMapping()
        {
            CreateMap<TeacherLoad, TeacherLoadDto>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.TeacherId))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Teacher.Name))
                .ForMember(dest => dest.LoadType, opt => opt.MapFrom(src => "Teacher"));

            CreateMap<SupervisorLoad, TeacherLoadDto>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.SupervisorId))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Supervisor.Name))
                .ForMember(dest => dest.LoadType, opt => opt.MapFrom(src => "Supervisor"));
        }
    }
}
