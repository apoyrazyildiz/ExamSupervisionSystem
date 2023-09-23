using ExamSupervisionSystem.Application.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Validations.FluentValidation
{
    internal class CourseValidator: AbstractValidator<CourseDto>
    {
        public CourseValidator()
        {
            RuleFor(course => course.CourseName).NotEmpty().WithMessage("Course name is required.");
            RuleFor(course => course.Credit).GreaterThan(0).WithMessage("Credit must be greater than 0.");
            RuleFor(course => course.Description).MaximumLength(100).WithMessage("Description can be up to 100 characters long.");
        }
    }
}
