using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DemoProj.Data.Repositories
{
    public class GenericRepository<T> :
        IRepository<T> where T : class
    {
        protected ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async virtual Task<T> Add(T entity)
        {
            var result = await _dbContext.AddAsync(entity);
            //await _dbContext.SaveChangesAsync();
            await SaveChanges();
            return result.Entity;
        }

        public async virtual Task<IEnumerable<T>> All()
        {
            var result = await _dbContext.Set<T>()
                .ToListAsync();

            return result;
        }

        public async virtual Task<T> Delete(T entity)
        {
            _dbContext.Remove(entity);
            await SaveChanges();

            return entity;

        }

        public async virtual Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            var result = await _dbContext.Set<T>()
                .AsQueryable()
                .Where(predicate)
                .ToListAsync();

            return result;
        }

        public async virtual Task<T> Get(int id)
        {
            var result = await _dbContext.FindAsync<T>(id);

            return result;
        }

        public async virtual Task<T> GetByProperty(Expression<Func<T, bool>> predicate)
        {
            var set = _dbContext.Set<T>();

            var result = await set.FirstOrDefaultAsync(predicate);

            return result;
        }

        public async virtual Task<bool> SaveChanges()
        {
            return (await _dbContext.SaveChangesAsync()) > 0;
        }

        public async virtual Task<T> Update(T entity)
        {
            var result = _dbContext.Update(entity).Entity;

            return result;
        }
    }
}