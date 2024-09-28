using Approvals.NET.Domain.Extensions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.Common
{
    public class UlidGuidValueGenerator : ValueGenerator<Guid>
    {
        public override bool GeneratesTemporaryValues => false;

        public override Guid Next(EntityEntry entry)
        {
            return GuidHelper.NewGuid();
        }
    }
}
