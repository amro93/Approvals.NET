namespace Approvals.NET.Domain.Entities.Approvals
{
    public class RequestVersion
    {
        public Guid Id { get; set; }
        public Guid RequestID { get; set; }
        public Guid VersionNumber { get; set; }
        public string RequestData { get; set; }
        public DateTime CreatedDate { get; set; }

        public Request Request { get; set; }
    }


}
