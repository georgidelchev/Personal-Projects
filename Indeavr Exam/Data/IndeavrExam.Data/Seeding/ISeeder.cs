using System;
using System.Threading.Tasks;

namespace IndeavrExam.Data.Seeding
{
    public interface ISeeder
    {
        Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider);
    }
}
