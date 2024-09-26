namespace Approvals.NET.Domain.Entities.Approvals
{
    public class ApprovalGroupMember
    {
        public int ApprovalGroupMemberID { get; set; }
        public int ApprovalGroupID { get; set; }
        public int UserID { get; set; }

        public ApprovalGroup ApprovalGroup { get; set; }
        public ApprovalUser User { get; set; }
    }


}
