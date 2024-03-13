using System;
using System.Threading.Tasks;

namespace MyLittleGithub.Data.Seeding;

public interface ISeeder
{
    Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider);
}
