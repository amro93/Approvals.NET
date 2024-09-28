using System;
using System.Collections.Generic;
using System.Text;

namespace Approvals.NET.Application.Identity.Users.Dto
{
    public class AuthenticationRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
