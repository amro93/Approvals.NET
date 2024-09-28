using System;

namespace Approvals.NET.Domain.Interfaces
{
    public interface IUpdateAuditedEntity<TUserPK, TUser> : ICreateAuditedEntity<TUserPK, TUser>, IUpdateAuditedEntity<TUserPK>
        where TUser : class
    {
        public TUser UpdatedBy { get; set; }
    }
}
