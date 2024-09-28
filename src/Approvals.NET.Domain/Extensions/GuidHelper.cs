using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Domain.Extensions
{
    public static class GuidHelper
    {
        public static new Guid NewGuid()
        {
            // ulid is rapid and efficient Guid v7 generator
            return Ulid.NewUlid().ToGuid();
        }
    }
}
