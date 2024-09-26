namespace Approvals.NET.Domain.Entities.Approvals
{
    public class Approval
    {
        public int ApprovalID { get; set; }
        public int RequestID { get; set; }
        public int ApproverID { get; set; }
        public DateTime ApprovalDate { get; set; }
        public string ApprovalStatus { get; set; }
        public string RejectionReason { get; set; }
        public int? StageID { get; set; }
        public int? ApprovalGroupID { get; set; }

        public Request Request { get; set; }
        public ApprovalUser Approver { get; set; }
        public ApprovalStage Stage { get; set; }
        public ApprovalGroup ApprovalGroup { get; set; }
        public ICollection<ApprovalCondition> ApprovalConditions { get; set; }
    }


}
