namespace Approvals.NET.Domain.Entities.Approvals
{
    public class Group
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }

        public ICollection<GroupMember> GroupMembers { get; set; }
        public ICollection<Approval> Approvals { get; set; }
    }


}
