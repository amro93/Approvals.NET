using System;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Common
{
    public abstract class CreateAuditedEntity<TUserPK> : ICreateAuditedEntity<TUserPK>
    {
        public DateTime? CreatedAt { get; set; }
        public TUserPK? CreatedById { get; set; }
    }

    public abstract class CreateAuditedEntity : CreateAuditedEntity<Guid>, IEntity<Guid>
    {
        public Guid Id { get; set; }
    }

}
