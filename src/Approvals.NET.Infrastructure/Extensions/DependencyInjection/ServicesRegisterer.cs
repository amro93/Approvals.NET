using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Approvals.NET.Infrastructure.EfCore.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Infrastructure.Extensions.DependencyInjection
{
    public static class ServicesRegisterer
    {
        public static void AddAppEfCore(this IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<ApplicationDbContext>(o =>
            {
                o.LogTo(Console.WriteLine);
                o.UseSqlServer(connectionString);
                o.EnableSensitiveDataLogging();
            });
        }
    }
}
