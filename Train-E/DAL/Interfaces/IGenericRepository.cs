using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Train_E.DAL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        bool Exists(Expression<Func<T,bool>> filter);
        IEnumerable<T> Get();
        T GetById(int id);
        void Insert(T entity);
        void Delete(T entity);
        void Delete(int id);
        void Delete(Expression<Func<T, bool>> filter);
    }
}
