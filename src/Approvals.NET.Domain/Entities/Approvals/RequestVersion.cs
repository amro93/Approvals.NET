namespace Approvals.NET.Domain.Entities.Approvals
{
    public class RequestVersion
    {
        public int RequestVersionID { get; set; }
        public int RequestID { get; set; }
        public int VersionNumber { get; set; }
        public string RequestData { get; set; }
        public DateTime CreatedDate { get; set; }

        public Request Request { get; set; }
    }


}
