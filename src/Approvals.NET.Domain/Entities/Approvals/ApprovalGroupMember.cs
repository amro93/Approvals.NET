namespace Approvals.NET.Domain.Entities.Approvals
{
    public class ApprovalGroupMember
    {
        public Guid Id { get; set; }
        public Guid ApprovalGroupID { get; set; }
        public Guid UserID { get; set; }

        public ApprovalGroup ApprovalGroup { get; set; }
        public ApprovalUser User { get; set; }
    }


}
