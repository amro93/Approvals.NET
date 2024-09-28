using System;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Common
{
    public abstract class UpdateAuditedEntity<TUserPK> : CreateAuditedEntity<TUserPK>, IUpdateAuditedEntity<TUserPK>
    {
        public TUserPK? UpdatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public abstract class UpdateAuditedEntity : UpdateAuditedEntity<Guid?>, IEntity<Guid>
    {
        public Guid Id { get; set; }
    }
}
