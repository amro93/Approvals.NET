using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Common
{
    public abstract class FullAuditedEntity<TUserPK> : SoftDeleteAuditedEntity<TUserPK>, IFullAuditedEntity<TUserPK>
    {
    }
    public abstract class FullAuditedEntity<TUserPK, TUser> : SoftDeleteAuditedEntity<TUserPK, TUser>, IFullAuditedEntity<TUserPK, TUser>
        where TUser : class
    {

    }
}
