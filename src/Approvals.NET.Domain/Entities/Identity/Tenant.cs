using Approvals.NET.Domain.Entities.Common;
using Approvals.NET.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Domain.Entities.Identity
{
    public class Tenant : FullAuditedEntity<Guid>, ITrackedEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? ConcurrencyStamp { get; set; }
        public bool IsDisabled { get; set; }
        public ICollection<TenantConnectionString> TenantConnectionStrings { get; set; }
    }
}
