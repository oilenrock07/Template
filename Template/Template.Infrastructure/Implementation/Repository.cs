using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using Template.Entities.DbContexts;
using Template.Infrastructure.Interfaces;

namespace Template.Infrastructure.Implementation
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly ApplicationDbContext _context;

        private DbSet<T> _dbset;
        public virtual DbSet<T> DbSet
        {
            get
            {
                return _dbset ?? _context.Set<T>();
            }
            set { _dbset = value; }
        }

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        #region Gets
        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public virtual IQueryable<T> Get(Expression<Func<T, bool>> expression)
        {
            return DbSet.Where(expression);
        }

        public virtual T FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return DbSet.FirstOrDefault(expression);
        }
        #endregion

        public virtual T Add(T entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        public virtual void Delete(T entity)
        {
            DbSet.Remove(entity);
        }
    }
}
