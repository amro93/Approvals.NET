using System;
using System.Data.SqlTypes;

namespace Approvals.NET.Domain.Interfaces
{
    public interface IMayHaveTenant<TenantPK>
    {
        public TenantPK? TenantId { get; set; }
    }
    public interface IMayHaveTenant : IMayHaveTenant<Guid?>
    {
    }
}
