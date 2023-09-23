using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Application.Interfaces.Repositories;
using ExamSupervisionSystem.Domain.Entities;

namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    internal class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<Course, CourseDto>();
            
        }
    }
}
