namespace Approvals.NET.Domain.Entities.Approvals
{
    public class ApprovalCondition
    {
        public Guid Id { get; set; }
        public Guid ApprovalID { get; set; }
        public Guid ConditionID { get; set; }
        public bool IsMet { get; set; }

        public Approval Approval { get; set; }
        public Condition Condition { get; set; }
    }


}
