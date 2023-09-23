using AutoMapper;
using ExamSupervisionSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    internal class CourseParticipantMapping : Profile
    {
        public CourseParticipantMapping()
        {
            CreateMap<CourseParticipant, CourseParticipantDto>()
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.Name));
        }
    }
}
