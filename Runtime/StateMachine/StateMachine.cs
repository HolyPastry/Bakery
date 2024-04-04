using System;
using System.Collections.Generic;

namespace Holypastry.Bakery 
{
    public class StateMachine
    {
        StateNode current;
        readonly Dictionary<Type, StateNode> nodes = new();
        readonly HashSet<ITransition> anyTransitions = new();

        public void Update()
        {
            var transition = GetTransition();
            if (transition != null)
            {
                ChangeState(transition.TargetState);
            }

            current.State?.Update();
        }

        private void ChangeState(IState targetState)
        {
            if (targetState == current.State) return;
            var previousState = current.State;
            var nextState = nodes[targetState.GetType()].State;

            previousState?.Exit();
            nextState.Enter();

            current = nodes[targetState.GetType()];


        }

        public void FixedUpdate()
        {
            current.State?.FixedUpdate();
        }



        public void SetState(object targetState)
        {
            current = nodes[targetState.GetType()];
            current.State.Enter();
        }

        private ITransition GetTransition()
        {
            foreach (var transition in anyTransitions)
            {
                if (transition.Predicate.Evaluate())
                {
                    return transition;
                }
            }
            foreach (var transition in current.Transitions)
            {
                if (transition.Predicate.Evaluate())
                {
                    return transition;
                }
            }
            return null;

        }

        public void AddTransition(IState from, IState to, IPredicate predicate)
        {
            StateNode fromNode = GetNode(from);
            StateNode toNode = GetNode(to);

            fromNode.AddTransition(toNode.State, predicate);
        }

        public void AddAnyTransition(IState to, IPredicate predicate)
        {
            anyTransitions.Add(new Transition(predicate, GetNode(to).State));
        }

        private StateNode GetNode(IState from)
        {
            if (!nodes.ContainsKey(from.GetType()))
            {
                nodes[from.GetType()] = new StateNode(from);
            }
            return nodes[from.GetType()];
        }

        private class StateNode
        {
            public IState State { get; }
            public HashSet<ITransition> Transitions { get; }

            public StateNode(IState state)
            {
                State = state;
                Transitions = new HashSet<ITransition>();
            }

            public void AddTransition(IState targetState, IPredicate predicate)
            {
                Transitions.Add(new Transition(predicate, targetState));
            }
        }

    }
}