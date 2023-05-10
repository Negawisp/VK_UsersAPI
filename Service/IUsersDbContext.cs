using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public interface IUsersDbContext
    {
        DbSet<User> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
