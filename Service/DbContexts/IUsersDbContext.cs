using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Service.DbContexts
{
    public interface IUsersDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserState> UserStates { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
