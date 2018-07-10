using System;
using System.Linq;
using System.Linq.Expressions;

namespace Template.Infrastructure.Interfaces
{
    public interface IRepository<T> where T: class
    {
        T GetById(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> expression);
        T FirstOrDefault(Expression<Func<T, bool>> expression);
        T Add(T entity);
        void Delete(T entity);
    }
}
