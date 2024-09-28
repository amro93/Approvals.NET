using System;

namespace Approvals.NET.Domain.Interfaces
{
    public interface ICreateAuditedEntity<TUserPK> : IEntity
    {
        public TUserPK? CreatedById { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
