using Sy.Core.Abstracts;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Sy.Business.Repository
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : IEntity<TKey>
    {

        public TEntity GetById(TKey id)
        {
            throw new NotImplementedException();
        }

        public TKey Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }
    }
}
