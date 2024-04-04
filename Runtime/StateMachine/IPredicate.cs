using System;

namespace Holypastry.Bakery 
{
    public interface IPredicate
    {
        bool Evaluate();
    }

    public interface ITransition
    {
        IPredicate Predicate { get; }
        IState TargetState { get; }
    }
}