using System;

namespace Approvals.NET.Domain.Interfaces
{
    public interface ICreateAuditedEntity<TUserPK, TUser> : ICreateAuditedEntity<TUserPK>
        where TUser : class
    {
        public TUser? CreatedBy { get; set; }
    }
}
