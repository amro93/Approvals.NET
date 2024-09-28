using System;

namespace Approvals.NET.Domain.Interfaces
{
    public interface IHaveTenant<TenantPK> : IMayHaveTenant<TenantPK>
         where TenantPK : notnull
    {

    }
    public interface IHaveTenant : IHaveTenant<Guid>
    {
    }
}
