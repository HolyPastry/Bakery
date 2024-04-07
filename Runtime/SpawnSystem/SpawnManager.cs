using UnityEngine;

namespace Holypastry.Bakery
{
    public abstract class SpawnManager : MonoBehaviour
    {

        [SerializeField] protected Transform[] spawnPoints;

        [SerializeField] protected ISpawnStrategy _spawnStrategy;


        public virtual void Awake()
        {


            // switch (spawnPointStrategyType)
            // {
            //     case SpawnPointStrategyType.Linear:
            //         _spawnStrategy = new LinearSpawnStrategy(spawnPoints);
            //         break;
            //     case SpawnPointStrategyType.Random:
            //         _spawnStrategy = new RandomSpawnStrategy(spawnPoints);
            //         break;
            // }
        }

        public abstract void Spawn();

    }
}

