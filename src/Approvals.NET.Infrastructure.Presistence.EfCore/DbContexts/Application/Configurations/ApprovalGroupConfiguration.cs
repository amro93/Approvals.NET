using Approvals.NET.Domain.Entities.Approvals;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application.Configurations
{
    public class ApprovalGroupConfiguration : IEntityTypeConfiguration<ApprovalGroup>
    {
        public void Configure(EntityTypeBuilder<ApprovalGroup> builder)
        {
            builder.HasMany(ag => ag.ApprovalGroupMembers)
                   .WithOne(agm => agm.ApprovalGroup)
                   .HasForeignKey(agm => agm.ApprovalGroupID);
        }
    }

}
