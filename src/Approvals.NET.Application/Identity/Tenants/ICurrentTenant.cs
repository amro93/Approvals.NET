using Approvals.NET.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Application.Identity.Tenants
{
    public interface ICurrentTenant<TenantPK>
        where TenantPK : struct
    {
        public TenantPK? TenantId { get; }
        public TenantPK GetTenantId();
        public Task<string> GetTenantNameAsync();
        public Task<string> GetConnectionStringAsync(string name = "Default");
        public Task<IAsyncDisposable> UseAsync(TenantPK? tenantId);
        public IDisposable Use(TenantPK? tenantId);
    }

    public interface ICurrentTenant : ICurrentTenant<Guid>
    {
        public string TenantIdString { get; }
    }
}
