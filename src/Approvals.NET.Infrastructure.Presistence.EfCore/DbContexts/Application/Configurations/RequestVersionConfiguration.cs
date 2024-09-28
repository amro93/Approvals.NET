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
                   .HasForeignKey(rv => rv.RequestID);
        }
    }

}
