using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Approvals.NET.Domain.Entities.Common;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Identity
{
    public class TenantConnectionString : FullAuditedEntity<Guid>, IEntity<Guid>, IHaveTenant<Guid>
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }
        public Tenant Tenant { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Hashed
        /// </summary>
        public string ConnectionString { get; set; }
    }
}
