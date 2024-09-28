using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Domain.Interfaces
{
    public interface IEntity
    {
    }

    public interface IEntity<T> : IEntity
    {
        public T Id { get; set; }
    }
}
