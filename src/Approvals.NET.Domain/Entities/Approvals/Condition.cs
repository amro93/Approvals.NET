namespace Approvals.NET.Domain.Entities.Approvals
{
    public class Condition
    {
        public Guid Id { get; set; }
        public string ConditionName { get; set; }
        public string ConditionExpression { get; set; }

        public ICollection<ApprovalCondition> ApprovalConditions { get; set; }
    }


}
