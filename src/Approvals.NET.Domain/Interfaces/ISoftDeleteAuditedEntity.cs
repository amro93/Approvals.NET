using System;

namespace Approvals.NET.Domain.Interfaces
{
    public interface ISoftDeleteAuditedEntity<TUserPK> : IUpdateAuditedEntity<TUserPK>, ISoftDeleteEntity
    {
        public TUserPK? DeletedById { get; set; }
    }
}
