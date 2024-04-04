using UnityEngine;

namespace Holypastry.Bakery 
{
    public abstract class SpawnManager : MonoBehaviour
    {

        [SerializeField] protected SpawnPointStrategyType spawnPointStrategyType = SpawnPointStrategyType.Linear;

        [SerializeField] protected Transform[] spawnPoints;

        protected ISpawnStrategy _spawnStrategy;

        protected enum SpawnPointStrategyType
        {
            Linear,
            Random
        }

        public virtual void Awake()
        {
            switch (spawnPointStrategyType)
            {
                case SpawnPointStrategyType.Linear:
                    _spawnStrategy = new LinearSpawnStrategy(spawnPoints);
                    break;
                case SpawnPointStrategyType.Random:
                    _spawnStrategy = new RandomSpawnStrategy(spawnPoints);
                    break;
            }
        }

        public abstract void Spawn();

    }
}

