﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.DbContexts;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<UsersDbContext>(options =>
                options.UseNpgsql(connectionString));
            services.AddScoped<IUsersDbContext>(provider =>
                provider.GetService<UsersDbContext>());
            return services;
        }
    }
}
