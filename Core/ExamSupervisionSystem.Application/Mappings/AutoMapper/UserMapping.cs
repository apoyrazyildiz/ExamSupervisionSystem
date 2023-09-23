using AutoMapper;
using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    internal class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<User, UserDto>();


        }

    }
}
