using UnityEngine;

namespace Holypastry
{

    public interface ISpawnableFactory<T> where T : Spawnable
    {
        public T Create(Transform spawnPoint);
    }
}

