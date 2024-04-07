using UnityEngine;

namespace Holypastry.Bakery
{
    public abstract class SpawnStrategy : MonoBehaviour
    {
        public abstract Transform NextSpawnPoint();
    }
}

