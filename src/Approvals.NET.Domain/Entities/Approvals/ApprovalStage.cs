namespace Approvals.NET.Domain.Entities.Approvals
{
    public class ApprovalStage
    {
        public Guid Id { get; set; }
        public Guid StageId { get; set; }
        public string StageName { get; set; }
        public Guid StageOrder { get; set; }

        public ICollection<Approval> Approvals { get; set; }
    }


}
