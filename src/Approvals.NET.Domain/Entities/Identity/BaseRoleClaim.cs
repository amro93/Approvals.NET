using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Identity
{
    public class BaseRoleClaim : IdentityRoleClaim<Guid>, IEntity, IMayHaveTenant
    {
        public BaseRoleClaim()
        {
        }

        public Guid? TenantId { get; set; }
    }

    public class BaseRoleClaim<TRole> : BaseRoleClaim, IEntity
    {
        public BaseRoleClaim()
        {
        }

        public virtual TRole Role { get; set; }
    }
}
