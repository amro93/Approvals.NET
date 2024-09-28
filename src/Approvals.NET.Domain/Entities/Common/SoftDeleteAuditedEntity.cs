using System;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Common
{
    public abstract class SoftDeleteAuditedEntity<TUserPK> : UpdateAuditedEntity<TUserPK>, ISoftDeleteAuditedEntity<TUserPK>
    {
        public TUserPK? DeletedById { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }

    public abstract class SoftDeleteAuditedEntity : SoftDeleteAuditedEntity<Guid?>, IEntity<Guid>
    {
        public Guid Id { get; set; }
    }

}
