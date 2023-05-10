using Microsoft.EntityFrameworkCore;
using Domain.Model;
using Domain.EntityConfiguraion;
using Service.DbContexts;

namespace Persistence
{
    public class UsersDbContext : DbContext, IUsersDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserState> UserStates { get; set; }

        public UsersDbContext(DbContextOptions<UsersDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserGroupConfiguration());
            modelBuilder.ApplyConfiguration(new UserStateConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
