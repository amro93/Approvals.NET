namespace Approvals.NET.Domain.Entities.Approvals
{
    public class GroupMember
    {
        public int GroupMemberID { get; set; }
        public int GroupID { get; set; }
        public int UserID { get; set; }

        public Group Group { get; set; }
        public ApprovalUser User { get; set; }
    }


}
