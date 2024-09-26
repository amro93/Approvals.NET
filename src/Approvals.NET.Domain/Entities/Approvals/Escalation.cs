namespace Approvals.NET.Domain.Entities.Approvals
{
    public class Escalation
    {
        public Guid Id { get; set; }
        public Guid RequestID { get; set; }
        public Guid OriginalApproverID { get; set; }
        public Guid EscalatedToID { get; set; }
        public DateTime EscalationDate { get; set; }

        public Request Request { get; set; }
        public ApprovalUser OriginalApprover { get; set; }
        public ApprovalUser EscalatedTo { get; set; }
    }


}
