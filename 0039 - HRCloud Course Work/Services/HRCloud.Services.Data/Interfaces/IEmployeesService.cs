using System.Collections.Generic;
using System.Threading.Tasks;

using HRCloud.Web.ViewModels.Employees;

namespace HRCloud.Services.Data.Interfaces
{
    public interface IEmployeesService
    {
        Task<bool> CreateAsync(CreateEmployeeInputModel input, string webRoot);

        Task<bool> DeleteAsync(string employeeId);

        Task EditAsync(EditEmployeeInputModel input, string employeeId);

        Task<T> GetDetailsAsync<T>(string employeeId);

        Task<T> GetByIdAsync<T>(string employeeId);

        Task<IEnumerable<T>> GetAllAsync<T>(string departmentName);

        Task<IEnumerable<T>> GetAllByDepartmentNameAsync<T>(string departmentName);

        Task<IEnumerable<KeyValuePair<string, string>>> GetAllAsKvpAsync(string departmentName);

        bool IsEmailExist(string email);

        bool IsEmployeeExistById(string employeeId);
    }
}
