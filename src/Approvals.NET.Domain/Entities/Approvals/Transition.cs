namespace Approvals.NET.Domain.Entities.Approvals
{
    public class Transition
    {
        public int TransitionID { get; set; }
        public int FromStateID { get; set; }
        public int ToStateID { get; set; }
        public string ActionRequired { get; set; }

        public State FromState { get; set; }
        public State ToState { get; set; }
    }


}
