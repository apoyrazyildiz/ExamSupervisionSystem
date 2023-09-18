using AutoMapper;
using ExamSupervisionSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Mappings
{
    internal class CourseMapping : Profile
    {
        public CourseMapping()
        {
            CreateMap<Course, CourseDto>();

        }
    }
