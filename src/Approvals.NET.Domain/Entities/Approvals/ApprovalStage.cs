namespace Approvals.NET.Domain.Entities.Approvals
{
    public class ApprovalStage
    {
        public int StageID { get; set; }
        public string StageName { get; set; }
        public int StageOrder { get; set; }

        public ICollection<Approval> Approvals { get; set; }
    }


}
