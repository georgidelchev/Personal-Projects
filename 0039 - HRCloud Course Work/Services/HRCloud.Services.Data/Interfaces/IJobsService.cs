using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRCloud.Services.Data.Interfaces
{
    public interface IJobsService
    {
        bool IsJobSalaryValid(int jobId, decimal salary);

        Task<IEnumerable<KeyValuePair<int, string>>> GetAllAsKvp();
    }
}
