using Approvals.NET.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Domain.Entities.Identity
{
    public class ApplicationRole : BaseRole<ApplicationUserRole, ApplicationRoleClaim>
    {
        public ApplicationRole()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }

        
    }
}
