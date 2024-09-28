using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Identity
{
    public class BaseUserClaim : IdentityUserClaim<Guid>, IEntity, IMayHaveTenant
    {
        public BaseUserClaim()
        {
        }

        public Guid? TenantId { get; set; }
    }
    public class BaseUserClaim<TUser> : BaseUserClaim, IEntity
    {
        public BaseUserClaim()
        {
        }

        public virtual TUser User { get; set; }
    }
}
