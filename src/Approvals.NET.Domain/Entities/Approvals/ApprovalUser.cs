using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Domain.Entities.Approvals
{
    public class ApprovalUser
    {
        public int ApprovalUserID { get; set; }
        public string UserIdentityId { get; set; }
        public int? DelegateID { get; set; }

        public ApprovalUser Delegate { get; set; }
        public ICollection<ApprovalUser> Delegates { get; set; }
        public ICollection<GroupMember> GroupMembers { get; set; }
        public ICollection<Approval> Approvals { get; set; }
        public ICollection<Escalation> OriginalEscalations { get; set; }
        public ICollection<Escalation> EscalatedToEscalations { get; set; }
        public ICollection<ApprovalGroupMember> ApprovalGroupMembers { get; set; }
    }

}
