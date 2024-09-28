using System;

namespace Approvals.NET.Application.Identity.Roles.Dto
{
    public class RoleUpdateDto : RoleCreateDto
    {
        public Guid Id { get; set; }
    }
}
