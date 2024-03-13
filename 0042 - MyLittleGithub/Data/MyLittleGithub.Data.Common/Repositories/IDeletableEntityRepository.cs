using System.Linq;

using MyLittleGithub.Data.Common.Models;

namespace MyLittleGithub.Data.Common.Repositories;

public interface IDeletableEntityRepository<TEntity> : IRepository<TEntity>
    where TEntity : class, IDeletableEntity
{
    IQueryable<TEntity> AllWithDeleted();

    IQueryable<TEntity> AllAsNoTrackingWithDeleted();

    void HardDelete(TEntity entity);

    void Undelete(TEntity entity);
}
