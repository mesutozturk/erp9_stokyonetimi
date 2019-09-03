using System;
using System.Linq;
using System.Linq.Expressions;

namespace Sy.Core.Abstracts
{
    public interface IRepository<TEntity, TKey>
        where TEntity : IEntity<TKey>
    {
        TEntity GetById(TKey id);
        TKey Insert(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        int Save();
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate = null);
    }
}
