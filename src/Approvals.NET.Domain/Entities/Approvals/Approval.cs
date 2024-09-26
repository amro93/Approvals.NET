namespace Approvals.NET.Domain.Entities.Approvals
{
    public class Approval
    {
        public Guid Id { get; set; }
        public Guid RequestID { get; set; }
        public Guid ApproverID { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string ApprovalStatus { get; set; }
        public string RejectionReason { get; set; }
        public Guid? StageID { get; set; }
        public Guid? ApprovalGroupID { get; set; }

        public Request Request { get; set; }
        public ApprovalUser Approver { get; set; }
        public ApprovalStage Stage { get; set; }
        public ApprovalGroup ApprovalGroup { get; set; }
        public ICollection<ApprovalCondition> ApprovalConditions { get; set; }
    }


}
