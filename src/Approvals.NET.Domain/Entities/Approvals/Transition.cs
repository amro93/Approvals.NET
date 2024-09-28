namespace Approvals.NET.Domain.Entities.Approvals
{
    public class Transition
    {
        public Guid Id { get; set; }
        public Guid FromStateId { get; set; }
        public Guid ToStateId { get; set; }
        public string ActionRequired { get; set; }

        public State FromState { get; set; }
        public State ToState { get; set; }
    }


}
