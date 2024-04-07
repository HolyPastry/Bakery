using UnityEngine;

namespace Holypastry.Bakery
{

    public interface ISpawnableFactory<T> where T : Spawnable
    {
        public T Create(Transform spawnPoint);
    }
}

