using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Domain.Entities.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Ulid.NewUlid().ToGuid();
            ConcurrencyStamp = Guid.NewGuid().ToString();
        }

        public ApplicationUser(string userName) : this()
        {
            UserName = userName;
        }


    }
}
