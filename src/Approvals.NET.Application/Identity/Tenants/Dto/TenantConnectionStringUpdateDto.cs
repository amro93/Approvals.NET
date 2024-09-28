using System;

namespace Approvals.NET.Application.Identity.Tenants.Dto
{
    public class TenantConnectionStringUpdateDto : TenantConnectionStringCreateDto
    {
        public Guid Id { get; set; }
    }
}
