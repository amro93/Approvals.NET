namespace Approvals.NET.Domain.Entities.Approvals
{
    public class ApprovalCondition
    {
        public int ApprovalConditionID { get; set; }
        public int ApprovalID { get; set; }
        public int ConditionID { get; set; }
        public bool IsMet { get; set; }

        public Approval Approval { get; set; }
        public Condition Condition { get; set; }
    }


}
