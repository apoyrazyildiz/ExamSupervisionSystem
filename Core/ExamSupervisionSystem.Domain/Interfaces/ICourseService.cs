using ExamSupervisionSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Domain.Interfaces
{
    internal interface ICourseService
    {
        Course GetCourseById(int id);
        List<Course> GetAllCourses();
        bool AssignSupervisor(int courseId, int supervisorId);
    }
}
