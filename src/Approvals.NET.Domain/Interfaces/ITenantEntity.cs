using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Domain.Interfaces
{
    public interface ITenantEntity: ITenantEntity<Guid, Guid>
    {

    }
    public interface ITenantEntity<TTenantPK> : IEntity, IHaveTenant<TTenantPK>
        where TTenantPK : notnull
    {

    }

    public interface ITenantEntity<TEntityPK, TTenantPK> : IEntity<TEntityPK>, IHaveTenant<TTenantPK>
        where TTenantPK : notnull
    {

    }
}
