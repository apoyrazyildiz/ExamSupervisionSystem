using ExamSupervisionSystem.Application.Mappings;
using ExamSupervisionSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Seeders
{
    internal class UserSeeder
    {
        private readonly UserManager<User> _userManager;

        public UserSeeder(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task SeedAsync()
        {
            if (await _userManager.FindByNameAsync("admin") == null)
            {
                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@example.com",
                };

                var result = await _userManager.CreateAsync(admin, "adminpassword");

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(admin, "Admin");
                }
            }

            // Diğer kullanıcılar ve rolleri burada eklenir
        }
    }
}
