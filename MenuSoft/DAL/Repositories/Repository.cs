using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace NewMenuSoft.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public void Create(TEntity t)
        {
            Context.Set<TEntity>().Add(t);
        }

        public void Delete(TEntity t)
        {
            var entry = Context.Entry(t);
            entry.State = EntityState.Deleted;
            Context.Set<TEntity>().Remove(t);
        }

        public void Update(TEntity t)
        {
            var entry = Context.Entry(t);
            Context.Set<TEntity>().Attach(t);
            entry.State = EntityState.Modified;
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            foreach (var t in entities)
            {
                var entry = Context.Entry(t);
                Context.Set<TEntity>().Attach(t);
                entry.State = EntityState.Modified;
            }
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public TEntity SingleOrDefault()
        {
            return Context.Set<TEntity>().SingleOrDefault();
        }

        public void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            foreach (var t in entities)
            {
                Context.Set<TEntity>().AddOrUpdate(t);
            }
        }
    }
}
