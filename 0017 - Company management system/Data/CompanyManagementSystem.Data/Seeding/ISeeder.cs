using System;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Data.Seeding
{
    public interface ISeeder
    {
        Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider);
    }
}
