using Approvals.NET.Domain.Entities.Approvals;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application.Configurations
{
    public class ApprovalConditionConfiguration : IEntityTypeConfiguration<ApprovalCondition>
    {
        public void Configure(EntityTypeBuilder<ApprovalCondition> builder)
        {
            builder.HasOne(ac => ac.Approval)
                   .WithMany(a => a.ApprovalConditions)
                   .HasForeignKey(ac => ac.ApprovalId);
        }
    }

}
