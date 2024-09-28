using Approvals.NET.Domain.Entities.Approvals;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application.Configurations
{
    public class ApprovalGroupMemberConfiguration : IEntityTypeConfiguration<ApprovalGroupMember>
    {
        public void Configure(EntityTypeBuilder<ApprovalGroupMember> builder)
        {
            builder.HasOne(agm => agm.User)
                   .WithMany(u => u.ApprovalGroupMembers)
                   .HasForeignKey(agm => agm.UserID);
        }
    }

}
