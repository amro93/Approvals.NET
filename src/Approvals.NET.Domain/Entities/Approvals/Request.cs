namespace Approvals.NET.Domain.Entities.Approvals
{
    public class Request
    {
        public int RequestID { get; set; }
        public int RequestorID { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestDetails { get; set; }
        public int CurrentStateID { get; set; }
        public int VersionNumber { get; set; }

        public ApprovalUser Requestor { get; set; }
        public State CurrentState { get; set; }
        public ICollection<Approval> Approvals { get; set; }
        public ICollection<RequestVersion> RequestVersions { get; set; }
        public ICollection<Escalation> Escalations { get; set; }
    }


}
