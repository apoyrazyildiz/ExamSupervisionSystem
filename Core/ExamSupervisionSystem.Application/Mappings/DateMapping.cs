using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Mappings
{
    internal class DateMapping : Profile
    {
        public CourseParticipantMapping()
        {
            CreateMap<CourseParticipant, CourseParticipantDto>();
        }
    }
}
