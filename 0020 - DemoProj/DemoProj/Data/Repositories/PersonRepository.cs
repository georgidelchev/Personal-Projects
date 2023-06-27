using DemoProj.Data.Entities;

namespace DemoProj.Data.Repositories
{
    public class PersonRepository : GenericRepository<Person>
    {
        public PersonRepository(ApplicationDbContext _dbContext)
        : base(_dbContext)
        {
        }
    }
}