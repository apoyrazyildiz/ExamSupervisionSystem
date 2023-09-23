using ExamSupervisionSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Seeders
{
    internal class RoleSeeder
    {
        private readonly RoleManager<Role> _roleManager;

        public RoleSeeder(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task SeedAsync()
        {
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new Role("Admin"));
            }
            if (!await _roleManager.RoleExistsAsync("Teacher"))
            {
                await _roleManager.CreateAsync(new Role("Teacher"));
            }
            if (!await _roleManager.RoleExistsAsync("Supervisor"))
            {
                await _roleManager.CreateAsync(new Role("Supervisor"));
            }
            if (!await _roleManager.RoleExistsAsync("Student"))
            {
                await _roleManager.CreateAsync(new Role("Student"));
            }
        }
    }
}
