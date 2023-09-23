using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Validations.FluentValidation
{
    internal class UserRegistrationValidator: AbstractValidator<UserRegistrationModel>
    {
        public UserRegistrationValidator()
        {
            RuleFor(user => user.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(user => user.LastName).NotEmpty().WithMessage("Last name is required.");
            RuleFor(user => user.Email).NotEmpty().WithMessage("Email is required.");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Invalid email format.");
            RuleFor(user => user.Password).NotEmpty().WithMessage("Password is required.");
            RuleFor(user => user.Password).MinimumLength(8).WithMessage("Password must be at least 8 characters long.");
        }
    }
}
