﻿using System;
using Approvals.NET.Domain.Interfaces;
using Approvals.NET.Domain.Entities.Identity;

namespace Approvals.NET.Domain.Entities.Identity
{
    public class ApplicationUserToken : BaseUserToken<ApplicationUser>, IEntity, IMayHaveTenant
    {
        public Guid? TenantId { get; set; }
    }
}
