using Microsoft.AspNetCore.Identity;
using System;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Identity
{

    public class BaseUserRole : IdentityUserRole<Guid>, IEntity, IMayHaveTenant
    {
        public BaseUserRole() : base()
        {
        }

        public Guid? TenantId { get; set; }
    }
    public class BaseUserRole<TUser, TRole> : BaseUserRole, IEntity
    {
        public BaseUserRole() : base()
        {
        }

        public virtual TUser User { get; set; }
        public virtual TRole Role { get; set; }
    }
}
