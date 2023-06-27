using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HRCloud.Data.Common.Repositories;
using HRCloud.Data.Models;
using HRCloud.Services.Data.Interfaces;
using HRCloud.Services.Mapping;
using Microsoft.EntityFrameworkCore;

namespace HRCloud.Services.Data
{
    public class DepartmentsService : IDepartmentsService
    {
        private readonly IDeletableEntityRepository<Department> departmentsRepository;

        public DepartmentsService(
            IDeletableEntityRepository<Department> departmentsRepository)
        {
            this.departmentsRepository = departmentsRepository;
        }

        public async Task<IEnumerable<T>> GetAll<T>()
            => await this.departmentsRepository
                .All()
                .Include(d => d.Employees)
                .To<T>()
                .ToListAsync();

        public async Task<IEnumerable<KeyValuePair<int, string>>> GetAllAsKvp()
            => await this.departmentsRepository
                .All()
                .Select(kvp => new KeyValuePair<int, string>(kvp.Id, kvp.Name))
                .ToListAsync();

        public int GetIdByName(string name)
            => this.departmentsRepository
                .All()
                .FirstOrDefault(d => d.Name == name)
                .Id;

        public bool IsDepartmentExist(string departmentName)
            => this.departmentsRepository
                .All()
                .Any(d => d.Name == departmentName);
    }
}
