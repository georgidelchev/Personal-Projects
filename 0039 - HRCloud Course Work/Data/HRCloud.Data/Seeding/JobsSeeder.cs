using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HRCloud.Common;
using HRCloud.Data.Models;

namespace HRCloud.Data.Seeding
{
    public class JobsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var jobs = new List<Job>()
            {
                new Job()
                {
                    Name = PositionsConstants.DeveloperName,
                    Description = PositionsConstants.DeveloperDescription,
                    MinSalary = PositionsConstants.MinSalaryDEV,
                    MaxSalary = PositionsConstants.MaxSalaryDEV,
                },
                new Job()
                {
                    Name = PositionsConstants.SolutionsArchitectName,
                    Description = PositionsConstants.SolutionsArchitectDescription,
                    MinSalary = PositionsConstants.MinSalarySA,
                    MaxSalary = PositionsConstants.MaxSalarySA,
                },
                new Job()
                {
                    Name = PositionsConstants.QualityAssuranceName,
                    Description = PositionsConstants.QualityAssuranceDescription,
                    MinSalary = PositionsConstants.MinSalaryQA,
                    MaxSalary = PositionsConstants.MaxSalaryQA,
                },
                new Job()
                {
                    Name = PositionsConstants.HumanResourceName,
                    Description = PositionsConstants.HumanResourceDescription,
                    MinSalary = PositionsConstants.MinSalaryHR,
                    MaxSalary = PositionsConstants.MaxSalaryHR,
                },
            };

            foreach (var job in jobs)
            {
                if (dbContext.Jobs.Any(j => j.Name == job.Name))
                {
                    continue;
                }

                await dbContext.Jobs.AddAsync(job);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
