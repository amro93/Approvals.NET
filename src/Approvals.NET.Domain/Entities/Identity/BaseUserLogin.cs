﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Identity
{
    public class BaseUserLogin : IdentityUserLogin<Guid>, IEntity, IMayHaveTenant
    {
        public BaseUserLogin()
        {
        }

        public Guid? TenantId { get; set; }
    }
    public class BaseUserLogin<TUser> : BaseUserLogin, IEntity
    {
        public BaseUserLogin()
        {
        }
        public virtual TUser User { get; set; }
    }
}
