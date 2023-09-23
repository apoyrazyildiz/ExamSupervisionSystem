using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Application.Interfaces.Repositories;

namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    internal class CourseMappingProfile: Profile
    {
        public CourseMappingProfile()
        {
            CreateMap<Course, CourseDto>()
                .ForMember(dest => dest.CourseDisplayName, opt => opt.MapFrom(src => $"{src.CourseCode} - {src.CourseName}"))
                .ForMember(dest => dest.CreditDisplay, opt => opt.MapFrom(src => $"{src.Credit} Credits"));
            
        }
    }
}
