using Approvals.NET.Domain.Entities.Approvals;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application.Configurations
{
    public class ConditionConfiguration : IEntityTypeConfiguration<Condition>
    {
        public void Configure(EntityTypeBuilder<Condition> builder)
        {
            builder.HasMany(c => c.ApprovalConditions)
                   .WithOne(ac => ac.Condition)
                   .HasForeignKey(ac => ac.ConditionID);
        }
    }

}
