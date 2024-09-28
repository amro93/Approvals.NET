using Approvals.NET.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Domain.Entities.Identity
{
    public class ApplicationUser : BaseUser<ApplicationUserRole, ApplicationUserClaim, ApplicationUserToken, ApplicationUserLogin>
    {
        public ApplicationUser()
        {
            Id = Ulid.NewUlid().ToGuid();
            ConcurrencyStamp = Guid.NewGuid().ToString();
        }

        public ApplicationUser(string userName) : base(userName)
        {
            Id = Ulid.NewUlid().ToGuid();
            ConcurrencyStamp = Guid.NewGuid().ToString();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
