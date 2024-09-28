using System;
using System.Collections.Generic;
using System.Text;

namespace Approvals.NET.Application.Identity.Users
{
    public interface ICurrentUser<TUserPK>
        where TUserPK : struct
    {
        public TUserPK? UserId { get; }
    }
    public interface ICurrentUser : ICurrentUser<Guid>
    {
        public string UserIdString { get; }

    }
}