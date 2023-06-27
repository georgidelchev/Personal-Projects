using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HRCloud.Common;
using HRCloud.Data.Models;

namespace HRCloud.Data.Seeding
{
    public class DepartmentsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var departments = new List<Department>()
            {
                new Department()
                {
                    Name = DepartmentsConstants.HumanResourcesDepartmentName,
                    Description = DepartmentsConstants.HumanResourceDepartmentDescription,
                },
                new Department()
                {
                    Name = DepartmentsConstants.DevelopersDepartmentName,
                    Description = DepartmentsConstants.DevelopersDepartmentDescription,
                },
                new Department()
                {
                    Name = DepartmentsConstants.QualityAssuranceDepartmentName,
                    Description = DepartmentsConstants.QualityAssuranceDepartmentDescription,
                },
                new Department()
                {
                    Name = DepartmentsConstants.ManagersDepartmentName,
                    Description = DepartmentsConstants.ManagersDepartmentDescription,
                },
            };

            foreach (var department in departments)
            {
                if (dbContext.Departments.Any(d => d.Name == department.Name))
                {
                    continue;
                }

                await dbContext.Departments.AddAsync(department);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
