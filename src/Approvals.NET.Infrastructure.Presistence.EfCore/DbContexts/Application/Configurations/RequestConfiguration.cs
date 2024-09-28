using Approvals.NET.Domain.Entities.Approvals;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application.Configurations
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasMany(r => r.Approvals)
                   .WithOne(a => a.Request)
                   .HasForeignKey(a => a.RequestId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
