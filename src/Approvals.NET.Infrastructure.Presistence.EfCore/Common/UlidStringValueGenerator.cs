using Approvals.NET.Domain.Extensions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.Common
{
    public class UlidStringValueGenerator : ValueGenerator<string>
    {
        public override bool GeneratesTemporaryValues => false;

        public override string Next(EntityEntry entry)
        {
            return GuidHelper.NewGuid().ToString();
        }
    }
}
