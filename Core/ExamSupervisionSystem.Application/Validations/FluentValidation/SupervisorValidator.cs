using ExamSupervisionSystem.Application.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Validations.FluentValidation
{
    internal class SupervisorValidator: AbstractValidator<SupervisorDto>
    {
        public SupervisorValidator()
        {
            RuleFor(supervisor => supervisor.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(supervisor => supervisor.LastName).NotEmpty().WithMessage("Last name is required.");
            // Diğer doğrulama kuralları burada tanımlanabilir.
        }
    }
}
