using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace TitanMessaging.EntityFramework
{
    public static class Extensions
    {
        public static IServiceCollection UseTitanEntityFramework(this IServiceCollection services, Action<DbContextOptionsBuilder> options)
        {
            services.AddDbContext<ChatDbContext>(options);
            return services;
        }
    }
}
