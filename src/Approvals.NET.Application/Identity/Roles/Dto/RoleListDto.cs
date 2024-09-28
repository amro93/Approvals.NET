using System;

namespace Approvals.NET.Application.Identity.Roles.Dto
{
    public class RoleListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public bool IsPublic { get; set; }
        public Guid? TenantId { get; set; }
    }
}
