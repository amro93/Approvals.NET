using Approvals.NET.Domain.Entities.Identity;
using Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Infrastructure.Presistence.EfCore
{
    public static class ServicesExtensions
    {
        public static void AddAppEfCore(this IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<ApplicationDbContext>(o =>
            {
                o.LogTo(Console.WriteLine);
                o.UseSqlServer(connectionString);
                o.EnableSensitiveDataLogging();
            });

            //services.AddIdentityCore<ApplicationUser>()
            //    .AddRoleManager<RoleManager<ApplicationRole>>()
            //    .AddUserManager<UserManager<ApplicationUser>>()
            //    .AddRoles<ApplicationRole>()
            //    .AddRoleValidator<ApplicationRole>()
            //    .AddUserStore<ApplicationUser>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();
        }
    }
}
