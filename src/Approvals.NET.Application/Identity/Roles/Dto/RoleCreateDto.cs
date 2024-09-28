using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Application.Identity.Roles.Dto
{
    public class RoleCreateDto
    {
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public bool IsPublic { get; set; }
    }
}
