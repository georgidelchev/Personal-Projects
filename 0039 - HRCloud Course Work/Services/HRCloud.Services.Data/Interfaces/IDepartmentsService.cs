using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRCloud.Services.Data.Interfaces
{
    public interface IDepartmentsService
    {
        Task<IEnumerable<T>> GetAll<T>();

        Task<IEnumerable<KeyValuePair<int, string>>> GetAllAsKvp();

        int GetIdByName(string name);

        bool IsDepartmentExist(string departmentName);
    }
}
