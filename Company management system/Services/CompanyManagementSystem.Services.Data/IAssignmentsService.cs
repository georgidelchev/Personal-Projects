using System.Collections.Generic;
using System.Threading.Tasks;

using CompanyManagementSystem.Web.ViewModels.Users;

namespace CompanyManagementSystem.Services.Data
{
    public interface IAssignmentsService
    {
        Task GiveAsync(GiveAssignmentInputModel input, string employeeId);

        Task<IEnumerable<T>> All<T>(string id);
    }
}
