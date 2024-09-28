using Approvals.NET.Domain.Entities.Approvals;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application.Configurations
{
    public class EscalationConfiguration : IEntityTypeConfiguration<Escalation>
    {
        public void Configure(EntityTypeBuilder<Escalation> builder)
        {
            builder.HasOne(e => e.Request)
                   .WithMany(r => r.Escalations)
                   .HasForeignKey(e => e.RequestId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.OriginalApprover)
                   .WithMany(u => u.OriginalEscalations)
                   .HasForeignKey(e => e.OriginalApproverId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.EscalatedTo)
                   .WithMany(u => u.EscalatedToEscalations)
                   .HasForeignKey(e => e.EscalatedToId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
