using Microsoft.EntityFrameworkCore;
using Approvals.NET.Domain.Entities.Approvals;
using Approvals.NET.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application.Configurations;
using Approvals.NET.Application.Identity.Tenants;
using Approvals.NET.Domain.Interfaces;
using Approvals.NET.Application.Identity.Users;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Approvals.NET.Infrastructure.Presistence.EfCore.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Approvals.NET.Infrastructure.Presistence.EfCore.DbContexts.Application
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid, ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin, ApplicationRoleClaim, ApplicationUserToken>
    {
        private readonly ICurrentTenant _currentTenant;
        private readonly ICurrentUser _currentUser;
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            _currentTenant = this.GetService<ICurrentTenant>();
            _currentUser = this.GetService<ICurrentUser>();
        }
        public DbSet<ApprovalUser> ApprovalUsers { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Transition> Transitions { get; set; }
        public DbSet<Approval> Approvals { get; set; }
        public DbSet<ApprovalStage> ApprovalStages { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupMember> GroupMembers { get; set; }
        public DbSet<Escalation> Escalations { get; set; }
        public DbSet<ApprovalGroup> ApprovalGroups { get; set; }
        public DbSet<ApprovalGroupMember> ApprovalGroupMembers { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<ApprovalCondition> ApprovalConditions { get; set; }
        public DbSet<RequestVersion> RequestVersions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationRole>(entity =>
            {
                entity.Property(t => t.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<ApplicationUserRole>(entity =>
            {
                entity.HasOne(t => t.Role).WithMany(t => t.UserRoles).HasForeignKey(t => t.RoleId);
                entity.HasOne(t => t.User).WithMany(t => t.UserRoles).HasForeignKey(t => t.UserId);
            });

            modelBuilder.Entity<ApplicationUserClaim>(entity =>
            {
                entity.HasOne(t => t.User).WithMany(t => t.UserClaims).HasForeignKey(t => t.UserId);
            });

            modelBuilder.Entity<ApplicationUserLogin>(entity =>
            {
                entity.HasOne(t => t.User).WithMany(t => t.UserLogins).HasForeignKey(t => t.UserId);
            });

            modelBuilder.Entity<ApplicationRoleClaim>(entity =>
            {
                entity.HasOne(t => t.Role).WithMany(t => t.RoleClaims).HasForeignKey(t => t.RoleId);

            });

            modelBuilder.Entity<ApplicationUserToken>(entity =>
            {
                entity.HasOne(t => t.User).WithMany(t => t.UserTokens).HasForeignKey(t => t.UserId);
            });

            modelBuilder.Entity<ApplicationUser>(e =>
            {
                e.ReplaceIndexesInPropertyWithTenantId(e => e.NormalizedUserName);
                e.ReplaceIndexesInPropertyWithTenantId(e => e.UserName);
                e.ReplaceIndexesInPropertyWithTenantId(e => e.Email);
                e.ReplaceIndexesInPropertyWithTenantId(e => e.NormalizedEmail);
            });

            modelBuilder.Entity<ApplicationRole>(e =>
            {
                e.ReplaceIndexesInPropertyWithTenantId(e => e.NormalizedName);
                e.ReplaceIndexesInPropertyWithTenantId(e => e.Name);
            });

            modelBuilder.ApplyConfiguration(new ApprovalUserConfiguration());
            modelBuilder.ApplyConfiguration(new StateConfiguration());
            modelBuilder.ApplyConfiguration(new RequestConfiguration());
            modelBuilder.ApplyConfiguration(new ApprovalConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new GroupMemberConfiguration());
            modelBuilder.ApplyConfiguration(new EscalationConfiguration());
            modelBuilder.ApplyConfiguration(new ApprovalGroupConfiguration());
            modelBuilder.ApplyConfiguration(new ApprovalGroupMemberConfiguration());
            modelBuilder.ApplyConfiguration(new ConditionConfiguration());
            modelBuilder.ApplyConfiguration(new ApprovalConditionConfiguration());
            modelBuilder.ApplyConfiguration(new RequestVersionConfiguration());
            modelBuilder.ApplyConfiguration(new TransitionConfiguration());

            var tenantId = _currentTenant?.TenantId;
            modelBuilder.SetQueryFilterOnAllEntities<ISoftDeleteEntity>(t => !t.IsDeleted);
            modelBuilder.SetQueryFilterOnAllEntities<IHaveTenant>(t => t.TenantId == tenantId);
            modelBuilder.SetQueryFilterOnAllEntities<IMayHaveTenant>(t => t.TenantId == tenantId);
        }
    }

}
