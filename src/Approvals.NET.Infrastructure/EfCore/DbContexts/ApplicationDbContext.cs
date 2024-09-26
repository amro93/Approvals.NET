using Microsoft.EntityFrameworkCore;
using Approvals.NET.Domain.Entities.Approvals;
using Approvals.NET.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Approvals.NET.Infrastructure.EfCore.DbContexts.Configurations;

namespace Approvals.NET.Infrastructure.EfCore.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
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

        }
    }

}
