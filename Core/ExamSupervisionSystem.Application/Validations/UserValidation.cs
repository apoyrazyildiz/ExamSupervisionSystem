using ExamSupervisionSystem.Application.Mappings;
using ExamSupervisionSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Validations
{
    internal class UserValidation
    {
        public static async Task<IdentityResult> ValidateUserAsync(UserManager<User> userManager, UserRegistrationValidationModel model)
        {
            var errors = new List<IdentityError>();

            if (string.IsNullOrWhiteSpace(model.FirstName))
            {
                errors.Add(new IdentityError { Description = "First name is required." });
            }

            if (string.IsNullOrWhiteSpace(model.LastName))
            {
                errors.Add(new IdentityError { Description = "Last name is required." });
            }

            if (string.IsNullOrWhiteSpace(model.Email))
            {
                errors.Add(new IdentityError { Description = "Email is required." });
            }
            else
            {
                var existingUser = await userManager.FindByEmailAsync(model.Email);
                if (existingUser != null)
                {
                    errors.Add(new IdentityError { Description = "Email is already in use." });
                }
            }

            

            return errors.Any()
                ? IdentityResult.Failed(errors.ToArray())
                : IdentityResult.Success;
        }
    }
}
