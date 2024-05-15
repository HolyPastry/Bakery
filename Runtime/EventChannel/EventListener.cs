
using UnityEngine;
using UnityEngine.Events;

namespace Holypastry.Bakery
{
    public class EventListener : EventListener<Empty>
    { }

    public abstract class EventListener<T> : MonoBehaviour
    {
        [SerializeField] EventChannel<T> _channel;
        [SerializeField] UnityEvent<T> _response;
        internal void Raise(T arg)
        {
            _response?.Invoke(arg);
        }

        void Awake()
        {
            _channel.Register(this);
        }

        void OnDestroy()
        {
            _channel.Unregister(this);
        }

    }
}
