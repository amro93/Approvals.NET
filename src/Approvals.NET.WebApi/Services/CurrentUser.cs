using Approvals.NET.Application.Identity.Users;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Approvals.NET.WebApi.Services
{
    public class CurrentUser : ICurrentUser
    {
        public CurrentUser(IHttpContextAccessor httpContextAccessor)
        {
            UserIdString = httpContextAccessor.HttpContext?.User?.FindFirstValue("uid");
        }

        public string UserIdString { get; }
        public Guid? UserId
        {
            get
            {
                var canParse = Guid.TryParse(UserIdString, out var value);
                if (!canParse) return null;
                return value;
            }
        }
    }
}
