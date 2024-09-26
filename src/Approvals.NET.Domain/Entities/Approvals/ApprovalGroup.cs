namespace Approvals.NET.Domain.Entities.Approvals
{
    public class ApprovalGroup
    {
        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public bool RequireAllApprovals { get; set; }

        public ICollection<ApprovalGroupMember> ApprovalGroupMembers { get; set; }
        public ICollection<Approval> Approvals { get; set; }
    }


}
