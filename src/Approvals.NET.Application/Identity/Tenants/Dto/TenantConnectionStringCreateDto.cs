using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Application.Identity.Tenants.Dto
{
    public class TenantConnectionStringCreateDto
    {
        [Required]
        public Guid? TenantId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ConnectionString { get; set; }
    }
}
