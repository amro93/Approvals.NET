using Approvals.NET.Domain.Entities.Approvals;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Approvals.NET.Infrastructure.EfCore.DbContexts.Configurations
{
    public class ApprovalUserConfiguration : IEntityTypeConfiguration<ApprovalUser>
    {
        public void Configure(EntityTypeBuilder<ApprovalUser> builder)
        {
            builder.HasMany(u => u.Delegates)
                   .WithOne(u => u.Delegate)
                   .HasForeignKey(u => u.DelegateID);
        }
    }

}
