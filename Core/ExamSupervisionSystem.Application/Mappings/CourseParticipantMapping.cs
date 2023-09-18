using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Mappings
{
    internal class CourseParticipantMapping : Profile
    {
        CreateMap<CourseParticipant, CourseParticipantDto>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.Name));
    }
}
