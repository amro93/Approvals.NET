using System;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Common
{
    public abstract class UpdateAuditedEntity<TUserPK, TUser> : CreateAuditedEntity<TUserPK, TUser>, IUpdateAuditedEntity<TUserPK, TUser>
        where TUser : class
    {
        public TUser UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public TUserPK? UpdatedById { get; set; }
    }

}
