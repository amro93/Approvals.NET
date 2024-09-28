using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Application.Identity.UserRoles.Dto
{
    public class UserRoleListDto
    {
        public Guid UserRoleId { get; set; }
        public Guid RoleId { get; set; }
        public string Name { get; set; }
    }
}
