using System;
using Approvals.NET.Domain.Entities.Identity;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Identity
{
    public class ApplicationRoleClaim : BaseRoleClaim<ApplicationRole>, IEntity, IMayHaveTenant
    {
    }
}
