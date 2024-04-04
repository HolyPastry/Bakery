namespace Holypastry.Bakery 
{
    public class Transition : ITransition
    {
        public IPredicate Predicate { get; }
        public IState TargetState { get; }

        public Transition(IPredicate predicate, IState targetState)
        {
            Predicate = predicate;
            TargetState = targetState;
        }
    }
}