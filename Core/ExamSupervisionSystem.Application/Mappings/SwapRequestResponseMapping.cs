using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Mappings
{
    internal class SwapRequestResponseMapping : Profile
    {
        public SwapRequestResponseMapping()
        {
            CreateMap<SwapRequestMapping, SwapRequestResponse>()
                .ForMember(dest => dest.Message, opt => opt.MapFrom(src => "Swap request created successfully."));

        }
    }
}
