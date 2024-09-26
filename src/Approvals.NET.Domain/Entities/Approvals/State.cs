namespace Approvals.NET.Domain.Entities.Approvals
{
    public class State
    {
        public int StateID { get; set; }
        public string StateName { get; set; }

        public ICollection<Request> Requests { get; set; }
        public ICollection<Transition> FromTransitions { get; set; }
        public ICollection<Transition> ToTransitions { get; set; }
    }


}
