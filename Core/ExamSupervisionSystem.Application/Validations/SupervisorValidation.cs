using ExamSupervisionSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Validations
{
    internal class SupervisorValidation
    {
        public static List<string> ValidateSupervisor(SupervisorDto supervisorDto)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(supervisorDto.FirstName))
            {
                errors.Add("First name is required.");
            }

            if (string.IsNullOrWhiteSpace(supervisorDto.LastName))
            {
                errors.Add("Last name is required.");
            }

            // Diğer doğrulama kuralları burada eklenir

            return errors;
        }
    }
}
