namespace Approvals.NET.Domain.Entities.Approvals
{
    public class Escalation
    {
        public int EscalationID { get; set; }
        public int RequestID { get; set; }
        public int OriginalApproverID { get; set; }
        public int EscalatedToID { get; set; }
        public DateTime EscalationDate { get; set; }

        public Request Request { get; set; }
        public ApprovalUser OriginalApprover { get; set; }
        public ApprovalUser EscalatedTo { get; set; }
    }


}
