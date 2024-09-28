namespace Approvals.NET.Domain.Entities.Approvals
{
    public class ApprovalCondition
    {
        public Guid Id { get; set; }
        public Guid ApprovalId { get; set; }
        public Guid ConditionId { get; set; }
        public bool IsMet { get; set; }

        public Approval Approval { get; set; }
        public Condition Condition { get; set; }
    }


}
