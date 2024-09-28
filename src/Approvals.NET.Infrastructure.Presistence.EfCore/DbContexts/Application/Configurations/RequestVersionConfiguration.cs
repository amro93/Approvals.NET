using Approvals.NET.Domain.Entities.Approvals;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application.Configurations
{
    public class RequestVersionConfiguration : IEntityTypeConfiguration<RequestVersion>
    {
        public void Configure(EntityTypeBuilder<RequestVersion> builder)
        {
            builder.HasOne(rv => rv.Request)
                   .WithMany(r => r.RequestVersions)
                   .HasForeignKey(rv => rv.RequestId);
        }
    }

    public class TransitionConfiguration : IEntityTypeConfiguration<Transition>
    {

        public void Configure(EntityTypeBuilder<Transition> builder)
        {
            builder.HasKey(r => r.Id); ;
            builder.HasOne(t => t.FromState).WithMany(t => t.FromTransitions).HasForeignKey(t => t.FromStateId).OnDelete(DeleteBehavior.ClientCascade);
            builder.HasOne(t => t.ToState).WithMany(t => t.ToTransitions).HasForeignKey(t => t.ToStateId).OnDelete(DeleteBehavior.ClientCascade);

        }
    }

}
