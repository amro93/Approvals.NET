using Approvals.NET.Domain.Entities.Common;
using Approvals.NET.Domain.Interfaces;
using Approvals.NET.Infrastructure.Presistence.EfCore.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.Extensions
{
    public static class EntityTypeExtension
    {
        public static class EntityTypeOrder
        {

        }
        public static void ConfigureBaseTypes<TUser>(this EntityTypeBuilder builder)
        {
            var entiyType = builder.GetType().GetGenericArguments().FirstOrDefault(t => t.IsAssignableFrom(typeof(EntityBase)));
            if (entiyType == null) return;
            ConfigureBaseTypes<TUser, Guid>(builder, entiyType);
        }
        public static void ConfigureBaseTypes<TUser, TUserPK>(this EntityTypeBuilder builder, Type entityType)
        {
            throw new NotImplementedException();
        }

        public static void ConfigureBaseTypes<T, TUser, TUserPK>(this EntityTypeBuilder<T> builder)
            where T : class
            where TUser : class, IEntity<TUserPK>
        {
            var entityType = typeof(T);

            if (typeof(ISoftDeleteAuditedEntity<TUserPK, TUser>).IsAssignableFrom(entityType))
            {
                builder.HasOne(t => ((ISoftDeleteAuditedEntity<TUserPK, TUser>)t).DeletedBy)
                    .WithMany()
                    .HasForeignKey(t => ((ISoftDeleteAuditedEntity<TUserPK, TUser>)t).DeletedById);
            }
            else if (typeof(ISoftDeleteAuditedEntity<TUserPK>).IsAssignableFrom(entityType))
            {
                builder.HasOne<TUser>()
                    .WithMany()
                    .HasForeignKey(t => ((ISoftDeleteAuditedEntity<TUserPK>)t).DeletedById);
            }

            if (typeof(IUpdateAuditedEntity<TUserPK, TUser>).IsAssignableFrom(entityType))
            {
                builder.HasOne(t => ((IUpdateAuditedEntity<TUserPK, TUser>)t).UpdatedBy)
                    .WithMany()
                    .HasForeignKey(t => ((IUpdateAuditedEntity<TUserPK, TUser>)t).UpdatedById);
            }
            else if (typeof(IUpdateAuditedEntity<TUserPK>).IsAssignableFrom(entityType))
            {
                builder.HasOne<TUser>()
                    .WithMany()
                    .HasForeignKey(t => ((IUpdateAuditedEntity<TUserPK>)t).UpdatedById);
            }

            if (typeof(ICreateAuditedEntity<TUserPK, TUser>).IsAssignableFrom(entityType))
            {
                builder.HasOne(t => ((ICreateAuditedEntity<TUserPK, TUser>)t).CreatedBy)
                    .WithMany()
                    .HasForeignKey((t) => ((ICreateAuditedEntity<TUserPK, TUser>)t).CreatedById);
            }
            else if (typeof(ICreateAuditedEntity<TUserPK>).IsAssignableFrom(entityType))
            {
                builder.HasOne<TUser>()
                    .WithMany()
                    .HasForeignKey((t) => ((ICreateAuditedEntity<TUserPK>)t).CreatedById);
            }
            if (typeof(IEntity<Guid>).IsAssignableFrom(entityType))
            {
                builder.HasKey(t => ((IEntity<Guid>)t).Id);
                builder.Property(t => ((IEntity<Guid>)t).Id)
                    .HasValueGenerator<UlidGuidValueGenerator>()
                    .ValueGeneratedOnAdd();
            }

            if (typeof(IMayHaveTenant<Guid>).IsAssignableFrom(entityType))
            {

            }
            if (typeof(IMayHaveTenant<Guid>).IsAssignableFrom(entityType))
            {

            }
        }

        public static void ConfigureBaseTypes<T, TPK>(this EntityTypeBuilder<T> builder)
            where T : class
            where TPK : IEquatable<TPK>
        {
            var entityType = typeof(T);

            if (typeof(IEntity<TPK>).IsAssignableFrom(entityType))
            {
                builder.HasKey(t => ((IEntity<TPK>)t).Id);
                builder.Property(t => ((IEntity<TPK>)t).Id)
                    .ValueGeneratedOnAdd().HasColumnOrder(1);
            }
            if(typeof(IEntity<Guid>).IsAssignableFrom(entityType))
            {
                builder.Property(t => ((IEntity<Guid>)t).Id).HasValueGenerator<UlidGuidValueGenerator>();
            }
            if (typeof(IEntity<string>).IsAssignableFrom(entityType))
            {
                builder.Property(t => ((IEntity<string>)t).Id).HasValueGenerator<UlidStringValueGenerator>();
            }
        }

        public static void ConfigureGuidUserBaseTypes<T, TUser>(this EntityTypeBuilder<T> builder)
            where T : class
            where TUser : class, IEntity<Guid>
        {
            ConfigureBaseTypes<T, TUser, Guid>(builder);
        }

        public static void ReplaceIndexesInPropertyWithTenantId<TEntity, TProperty>(this EntityTypeBuilder<TEntity> e, Expression<Func<TEntity, TProperty>> propertyExpression)
            where TEntity : class, IMayHaveTenant
        {
            var property = e.Property(propertyExpression);
            var indexes = property.Metadata.GetContainingIndexes().Where(t => t.IsUnique).ToList();
            if (indexes?.Any() ?? false) return;
            var tenantProperty = e.Property(t => t.TenantId).Metadata;
            var entityType = e.Metadata;
            foreach (var index in indexes)
            {
                var indexProperties = index.Properties;
                var index2 = entityType.AddIndex([..indexProperties, tenantProperty]);
                index2.IsUnique = index.IsUnique;
                index2.IsDescending = index.IsDescending;
                entityType.RemoveIndex(index);
            }
        }
    }
}
