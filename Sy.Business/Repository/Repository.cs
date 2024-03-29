﻿using Sy.Core.Abstracts;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using Sy.DataAccess;

namespace Sy.Business.Repository
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {
        public readonly StockDbContext Context;
        private readonly DbSet<TEntity> _table;

        public Repository()
        {
            Context = new StockDbContext();
            _table = Context.Set<TEntity>();
        }
        public TEntity GetById(TKey id)
        {
            return _table.Find(id);
        }

        public TKey Insert(TEntity entity)
        {
            _table.Add(entity);
            this.Save();
            return entity.Id;
        }

        public int Update(TEntity entity)
        {
            _table.AddOrUpdate(entity);
            return this.Save();
        }

        public int Delete(TEntity entity)
        {
            _table.Remove(entity);
            return this.Save();
        }

        public int Save()
        {
            return Context.SaveChanges();
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null ? _table : _table.Where(predicate);
        }
    }
}
