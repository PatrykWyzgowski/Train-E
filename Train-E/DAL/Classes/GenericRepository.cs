using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Train_E.DAL.Interfaces;

namespace Train_E.DAL.Classes
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private TrainEContext context;
        private DbSet<T> dbSet;

        public GenericRepository(TrainEContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }        

        public virtual bool Exists(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            return query.Any(filter);
        }

        public virtual IEnumerable<T> Get()
        {
            return dbSet.ToList();
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            T entityToDelete = dbSet.Find(entity);
            dbSet.Remove(entityToDelete);
        }

        public virtual void Delete(int id)
        {
            T entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(Expression<Func<T, bool>> filter)
        {
            T entityToDelete = dbSet.FirstOrDefault(filter);
            Delete(entityToDelete);

        
        }

    }
}