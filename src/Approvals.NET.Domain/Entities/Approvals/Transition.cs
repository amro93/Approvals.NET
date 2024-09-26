namespace Approvals.NET.Domain.Entities.Approvals
{
    public class Transition
    {
        public Guid Id { get; set; }
        public Guid FromStateID { get; set; }
        public Guid ToStateID { get; set; }
        public string ActionRequired { get; set; }

        public State FromState { get; set; }
        public State ToState { get; set; }
    }


}
