using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Application.Identity.Users.Dto
{
    public class UserUpdateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string PhoneNumber { get; set; }
    }
}
