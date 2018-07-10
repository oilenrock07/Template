using Template.Entities.DbContexts;
using Template.Infrastructure.Interfaces;

namespace Template.Infrastructure.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual void Commit()
        {
            _context.SaveChanges();
        }
    }
}
