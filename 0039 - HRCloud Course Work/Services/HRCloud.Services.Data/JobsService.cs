using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HRCloud.Data.Common.Repositories;
using HRCloud.Data.Models;
using HRCloud.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HRCloud.Services.Data
{
    public class JobsService : IJobsService
    {
        private readonly IDeletableEntityRepository<Job> jobsRepository;

        public JobsService(
            IDeletableEntityRepository<Job> jobsRepository)
        {
            this.jobsRepository = jobsRepository;
        }

        public bool IsJobSalaryValid(int jobId, decimal salary)
        {
            var job = this.jobsRepository
                .All()
                .FirstOrDefault(j => j.Id == jobId);

            return salary >= job.MinSalary && salary <= job.MaxSalary;
        }

        public async Task<IEnumerable<KeyValuePair<int, string>>> GetAllAsKvp()
            => await this.jobsRepository
                .All()
                .Select(kvp => new KeyValuePair<int, string>(kvp.Id, kvp.Name))
                .ToListAsync();
    }
}
