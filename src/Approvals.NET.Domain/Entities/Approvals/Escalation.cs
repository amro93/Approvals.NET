namespace Approvals.NET.Domain.Entities.Approvals
{
    public class Escalation
    {
        public Guid Id { get; set; }
        public Guid RequestId { get; set; }
        public Guid OriginalApproverId { get; set; }
        public Guid EscalatedToId { get; set; }
        public DateTime EscalationDate { get; set; }

        public Request Request { get; set; }
        public ApprovalUser OriginalApprover { get; set; }
        public ApprovalUser EscalatedTo { get; set; }
    }


}
