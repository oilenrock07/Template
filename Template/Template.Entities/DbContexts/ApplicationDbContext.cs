using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Template.Entities.Entities.Accounts;
using Template.Entities.Entities.Customers;

namespace Template.Entities.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base (options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
