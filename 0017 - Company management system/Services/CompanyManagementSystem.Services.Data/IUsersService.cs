using System.Collections.Generic;
using System.Threading.Tasks;

using CompanyManagementSystem.Data.Models;
using CompanyManagementSystem.Web.ViewModels.Users;

namespace CompanyManagementSystem.Services.Data
{
    public interface IUsersService
    {
        Task CreateAsync(string userId, CreateUserInputModel model);

        Task<IEnumerable<T>> GetAllAsync<T>(string managerId);

        Task<IEnumerable<KeyValuePair<string, string>>> GetAllAsKeyValuePairsAsync(string userId);

        Task DeleteAsync(string id);

        ApplicationUser GetById(string id);

        T GetByModel<T>(string id);

        Task EditAsync(EditUserInputModel input, string id);
    }
}
