using System.Collections.Generic;
using UnityEngine;

namespace Holypastry.Bakery
{
    public abstract class EventChannel<T> : ScriptableObject
    {
        protected readonly HashSet<EventListener<T>> _listeners = new();

        public void Invoke(T arg)
        {
            foreach (var listener in _listeners)
            {
                listener.Raise(arg);
            }
        }

        public void Register(EventListener<T> listener) => _listeners.Add(listener);

        public void Unregister(EventListener<T> listener) => _listeners.Remove(listener);

    }

    [CreateAssetMenu(menuName = "EventChannel/EmptyEventChannel")]
    public class EventChannel : EventChannel<Empty>
    {

    }

    public struct Empty
    {
    }
}
