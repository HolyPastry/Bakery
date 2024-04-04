using UnityEngine;

namespace Holypastry.Bakery 
{
    public class SpawnableFactory<T> : ISpawnableFactory<T> where T : Spawnable
    {

        SpawnableData[] _entityData;

        public SpawnableFactory(SpawnableData[] entityData)
        {
            _entityData = entityData;
        }

        public T Create(Transform spawnPoint)
        {
            SpawnableData data = _entityData[Random.Range(0, _entityData.Length)];

            GameObject instance = GameObject.Instantiate(data.prefab, spawnPoint.position, spawnPoint.rotation);
            return instance.GetComponent<T>();
        }
    }
}

