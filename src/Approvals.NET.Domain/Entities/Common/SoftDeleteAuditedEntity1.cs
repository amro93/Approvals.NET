using System;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Common
{
    public abstract class SoftDeleteAuditedEntity<TUserPK, TUser> : UpdateAuditedEntity<TUserPK, TUser>, ISoftDeleteAuditedEntity<TUserPK, TUser>
        where TUser : class
    {
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public TUserPK? DeletedById { get; set; }
        public TUser DeletedBy { get; set; }
    }

}
