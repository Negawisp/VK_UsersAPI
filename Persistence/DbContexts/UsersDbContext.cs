using Service;
using Microsoft.EntityFrameworkCore;
using Domain.Model;
using Domain.EntityConfiguraion;

namespace Persistence.DbContexts
{
    public class UsersDbContext : DbContext, IUsersDbContext
    {
        public DbSet<User> Users { get; set; }

        public UsersDbContext(DbContextOptions<UsersDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
