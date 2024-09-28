using System;

namespace Approvals.NET.Domain.Interfaces
{
    public interface IUpdateAuditedEntity<TUserPK> : ICreateAuditedEntity<TUserPK> 
    {
        public TUserPK? UpdatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
