using Approvals.NET.Domain.Entities.Approvals;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Approvals.NET.Infrastructure.EfCore.DbContexts.Configurations
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasMany(s => s.Requests)
                   .WithOne(r => r.CurrentState)
                   .HasForeignKey(r => r.CurrentStateID);

            builder.HasMany(s => s.FromTransitions)
                   .WithOne(t => t.FromState)
                   .HasForeignKey(t => t.FromStateID);

            builder.HasMany(s => s.ToTransitions)
                   .WithOne(t => t.ToState)
                   .HasForeignKey(t => t.ToStateID);
        }
    }

}
