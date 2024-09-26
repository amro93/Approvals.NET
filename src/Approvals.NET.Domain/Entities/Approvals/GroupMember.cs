namespace Approvals.NET.Domain.Entities.Approvals
{
    public class GroupMember
    {
        public Guid Id { get; set; }
        public Guid GroupID { get; set; }
        public Guid UserID { get; set; }

        public Group Group { get; set; }
        public ApprovalUser User { get; set; }
    }


}
