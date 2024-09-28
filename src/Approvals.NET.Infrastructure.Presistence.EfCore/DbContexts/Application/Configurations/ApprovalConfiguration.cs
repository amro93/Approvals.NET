using Approvals.NET.Domain.Entities.Approvals;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application.Configurations
{
    public class ApprovalConfiguration : IEntityTypeConfiguration<Approval>
    {
        public void Configure(EntityTypeBuilder<Approval> builder)
        {
            builder.HasOne(a => a.Stage)
                   .WithMany(s => s.Approvals)
                   .HasForeignKey(a => a.StageID);

            builder.HasOne(a => a.ApprovalGroup)
                   .WithMany(ag => ag.Approvals)
                   .HasForeignKey(a => a.ApprovalGroupID);
        }
    }

}
