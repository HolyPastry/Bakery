using UnityEngine;

namespace Holypastry.Bakery
{
    public interface ISpawnStrategy
    {
        public Transform NextSpawnPoint();
    }
}

