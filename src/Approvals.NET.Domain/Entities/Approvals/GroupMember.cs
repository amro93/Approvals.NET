namespace Approvals.NET.Domain.Entities.Approvals
{
    public class GroupMember
    {
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }

        public Group Group { get; set; }
        public ApprovalUser User { get; set; }
    }


}
