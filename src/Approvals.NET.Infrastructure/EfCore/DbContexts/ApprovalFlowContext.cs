using Microsoft.EntityFrameworkCore;
using Approvals.NET.Domain.Entities.Approvals;

namespace Approvals.NET.Infrastructure.EfCore.DbContexts
{
    public class ApprovalFlowContext : DbContext
    {
        public DbSet<ApprovalUser> Users { get; set; }
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
            // User-Delegate relationship
            modelBuilder.Entity<ApprovalUser>()
                .HasMany(u => u.Delegates)
                .WithOne(u => u.Delegate)
                .HasForeignKey(u => u.DelegateID);

            // State-Request relationship
            modelBuilder.Entity<State>()
                .HasMany(s => s.Requests)
                .WithOne(r => r.CurrentState)
                .HasForeignKey(r => r.CurrentStateID);

            // State-Transition relationships
            modelBuilder.Entity<State>()
                .HasMany(s => s.FromTransitions)
                .WithOne(t => t.FromState)
                .HasForeignKey(t => t.FromStateID);

            modelBuilder.Entity<State>()
                .HasMany(s => s.ToTransitions)
                .WithOne(t => t.ToState)
                .HasForeignKey(t => t.ToStateID);

            // Request-Approval relationship
            modelBuilder.Entity<Request>()
                .HasMany(r => r.Approvals)
                .WithOne(a => a.Request)
                .HasForeignKey(a => a.RequestID);

            // Approval-Stage relationship
            modelBuilder.Entity<Approval>()
                .HasOne(a => a.Stage)
                .WithMany(s => s.Approvals)
                .HasForeignKey(a => a.StageID);

            // Approval-ApprovalGroup relationship
            modelBuilder.Entity<Approval>()
                .HasOne(a => a.ApprovalGroup)
                .WithMany(ag => ag.Approvals)
                .HasForeignKey(a => a.ApprovalGroupID);

            // Group-GroupMember relationship
            modelBuilder.Entity<Group>()
                .HasMany(g => g.GroupMembers)
                .WithOne(gm => gm.Group)
                .HasForeignKey(gm => gm.GroupID);

            // GroupMember-User relationship
            modelBuilder.Entity<GroupMember>()
                .HasOne(gm => gm.User)
                .WithMany(u => u.GroupMembers)
                .HasForeignKey(gm => gm.UserID);

            // Escalation relationships
            modelBuilder.Entity<Escalation>()
                .HasOne(e => e.Request)
                .WithMany(r => r.Escalations)
                .HasForeignKey(e => e.RequestID);

            modelBuilder.Entity<Escalation>()
                .HasOne(e => e.OriginalApprover)
                .WithMany(u => u.OriginalEscalations)
                .HasForeignKey(e => e.OriginalApproverID);

            modelBuilder.Entity<Escalation>()
                .HasOne(e => e.EscalatedTo)
                .WithMany(u => u.EscalatedToEscalations)
                .HasForeignKey(e => e.EscalatedToID);

            // ApprovalGroup-ApprovalGroupMember relationship
            modelBuilder.Entity<ApprovalGroup>()
                .HasMany(ag => ag.ApprovalGroupMembers)
                .WithOne(agm => agm.ApprovalGroup)
                .HasForeignKey(agm => agm.ApprovalGroupID);

            // ApprovalGroupMember-User relationship
            modelBuilder.Entity<ApprovalGroupMember>()
                .HasOne(agm => agm.User)
                .WithMany(u => u.ApprovalGroupMembers)
                .HasForeignKey(agm => agm.UserID);

            // Condition-ApprovalCondition relationship
            modelBuilder.Entity<Condition>()
                .HasMany(c => c.ApprovalConditions)
                .WithOne(ac => ac.Condition)
                .HasForeignKey(ac => ac.ConditionID);

            // Approval-ApprovalCondition relationship
            modelBuilder.Entity<ApprovalCondition>()
                .HasOne(ac => ac.Approval)
                .WithMany(a => a.ApprovalConditions)
                .HasForeignKey(ac => ac.ApprovalID);

            // Request-RequestVersion relationship
            modelBuilder.Entity<RequestVersion>()
                .HasOne(rv => rv.Request)
                .WithMany(r => r.RequestVersions)
                .HasForeignKey(rv => rv.RequestID);
        }
    }

}
