namespace Approvals.NET.Domain.Entities.Approvals
{
    public class ApprovalGroupMember
    {
        public Guid Id { get; set; }
        public Guid ApprovalGroupId { get; set; }
        public Guid UserId { get; set; }

        public ApprovalGroup ApprovalGroup { get; set; }
        public ApprovalUser User { get; set; }
    }


}
