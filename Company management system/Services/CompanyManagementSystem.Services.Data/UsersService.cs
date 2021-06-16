using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyManagementSystem.Common;
using CompanyManagementSystem.Data.Common.Repositories;
using CompanyManagementSystem.Data.Models;
using CompanyManagementSystem.Services.Mapping;
using CompanyManagementSystem.Web.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementSystem.Services.Data
{
    public class UsersService : IUsersService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public UsersService(
            IDeletableEntityRepository<ApplicationUser> usersRepository,
            UserManager<ApplicationUser> userManager)
        {
            this.usersRepository = usersRepository;
            this.userManager = userManager;
        }

        public async Task CreateAsync(string userId, CreateUserInputModel model)
        {
            var employee = new ApplicationUser()
            {
                CreatedOn = DateTime.UtcNow,
                Email = model.Email,
                AccessFailedCount = 0,
                EmailConfirmed = false,
                IsDeleted = false,
                UserName = model.Email,
                Salary = model.Salary,
                Id = Guid.NewGuid().ToString(),
                LockoutEnabled = false,
            };

            var user = this.usersRepository
                .All()
                .FirstOrDefault(m => m.Id == userId);

            await this.userManager.CreateAsync(employee, model.Password);
            await this.usersRepository.SaveChangesAsync();

            user.Employees.Add(new ManagerEmployee()
            {
                ManagerId = user.Id,
                EmployeeId = employee.Id,
            });

            await this.usersRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(string managerId)
            => await this.usersRepository
                .All()
                .Where(u => u.Employees.All(e => e.ManagerId == managerId))
                .To<T>()
                .ToListAsync();

        public async Task<IEnumerable<KeyValuePair<string, string>>> GetAllAsKeyValuePairsAsync(string userId)
        {
            return await this.usersRepository
                .All()
                .Select(e => new
                {
                    e.Email,
                    e.Id,
                })
                .Select(e => new KeyValuePair<string, string>(e.Id, e.Email))
                .ToListAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var user = await this.usersRepository
                .All()
                .FirstOrDefaultAsync(u => u.Id == id);

            this.usersRepository.Delete(user);
            await this.usersRepository.SaveChangesAsync();
        }

        public ApplicationUser GetById(string id)
            => this.usersRepository
                .All()
                .FirstOrDefault(u => u.Id == id);

        public T GetByModel<T>(string id)
            => this.usersRepository
                .All()
                .Where(u => u.Id == id)
                .To<T>()
                .FirstOrDefault();

        public async Task EditAsync(EditUserInputModel input, string id)
        {
            var user = this.usersRepository
                .All()
                .FirstOrDefault(u => u.Id == id);

            user.Salary = input.Salary;

            this.usersRepository.Update(user);
            await this.usersRepository.SaveChangesAsync();
        }
    }
}
