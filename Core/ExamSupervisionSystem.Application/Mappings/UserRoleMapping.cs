using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Mappings
{
    internal class UserRoleMapping : Profile
    {
        public UserRoleMapping()
        {
            CreateMap<UserRole, UserRoleDto>()
                .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Role.Name))
                .ForMember(dest => dest.PermissionList, opt => opt.MapFrom(src => src.Role.Permissions));

 
        }
    }
}
