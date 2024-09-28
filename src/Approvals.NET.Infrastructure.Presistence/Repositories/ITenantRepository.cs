using Approvals.NET.Domain.Entities.Identity;
using Approvals.NET.Infrastructure.Presistence.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Infrastructure.Presistence.Repositories
{
    public interface ITenantRepository : IBaseRepository<Tenant, Guid>
    {
    }
}
