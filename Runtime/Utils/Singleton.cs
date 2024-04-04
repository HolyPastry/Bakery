using System;
using UnityEngine;


namespace Holypastry.Bakery
{
    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static readonly Lazy<T> LazyInstance = new(CreateSingleton);

        public static T Instance => LazyInstance.Value;

        private static T CreateSingleton()
        {
            T instance = GameObject.FindObjectOfType<T>();

            if (instance == null)
            {
                var o = new GameObject($"{typeof(T).Name} (singleton)");
                instance = o.AddComponent<T>();
                DontDestroyOnLoad(instance.gameObject);
            }
            return instance;
        }
    }
}