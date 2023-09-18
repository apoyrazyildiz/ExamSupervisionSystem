using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Mappings
{
    internal class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<User, UserDto>(); 

            
        }

    }
}
