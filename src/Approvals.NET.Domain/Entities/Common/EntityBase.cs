using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Approvals.NET.Domain.Entities.Common;
using Approvals.NET.Domain.Interfaces;

namespace Approvals.NET.Domain.Entities.Common
{
    public abstract class EntityBase : IEntity
    {
    }
    public abstract class Entity<T> : EntityBase, IEntity<T>
    {
        public T Id { get; set; }
    }
}