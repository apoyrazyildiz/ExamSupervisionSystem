using ExamSupervisionSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Validations
{
    internal class CourseValidation
    {
        public static List<string> ValidateCourse(CourseDto courseDto)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(courseDto.CourseName))
            {
                errors.Add("Course name is required.");
            }

            if (courseDto.Credit <= 0)
            {
                errors.Add("Credit value must be greater than 0.");
            }

            // Diğer doğrulama kuralları burada eklenir

            return errors;
        }
    }
}
