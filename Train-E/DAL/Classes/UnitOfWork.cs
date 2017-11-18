using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train_E.DAL.Classes
{
    internal class UnitOfWork : IUnitOfWork
    {
        private TrainEContext context = new TrainEContext();

        private Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            if (repositories.Keys.Contains(typeof(T)) == true)
            {
                return repositories[typeof(T)] as IGenericRepository<T>;
            }
            IGenericRepository<T> repo = new GenericRepository<T>(db);
            repositories.Add(typeof(T), repo);
            return repo;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}