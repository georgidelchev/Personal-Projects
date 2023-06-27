using System;
using System.Linq;
using System.Threading.Tasks;

using HRCloud.Common;
using HRCloud.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace HRCloud.Data.Seeding
{
    public class AdministratorSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

            if (!await roleManager.RoleExistsAsync(GlobalConstants.AdministratorRoleName) ||
                userManager.Users.Any(u => u.Email == "admin@example.com"))
            {
                return;
            }

            var user = new ApplicationUser()
            {
                Email = "admin@example.com",
                CreatedOn = DateTime.UtcNow,
                UserName = "admin@example.com",
                FirstName = "ADMIN",
                Surname = "ADMIN",
                LastName = "ADMIN",
                HireDate = DateTime.UtcNow,
                DepartmentId = dbContext.Departments.FirstOrDefault(d => d.Name == DepartmentsConstants.HumanResourcesDepartmentName).Id,
                JobId = dbContext.Jobs.FirstOrDefault(j => j.Name == PositionsConstants.HumanResourceName).Id,
                Salary = dbContext.Jobs.FirstOrDefault(j => j.Name == PositionsConstants.HumanResourceName).MinSalary,
                PhoneNumber = "0123456789",
                ImageUrl = "http://simpleicon.com/wp-content/uploads/account.png",
                WelcomeCardUrl = string.Empty,
            };

            await userManager.CreateAsync(user, "123456");
            await userManager.AddToRoleAsync(user, GlobalConstants.AdministratorRoleName);
        }
    }
}
