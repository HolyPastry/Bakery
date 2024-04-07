using UnityEngine;

namespace Holypastry.Bakery
{
    public abstract class SpawnManager : MonoBehaviour
    {
        // [SerializeField] protected ISpawnStrategy _spawnStrategy;
        public abstract void Spawn();
    }

    // //  [SerializeField] protected Transform[] spawnPoints;




    // public virtual void Awake()
    // {


    //     // switch (spawnPointStrategyType)
    //     // {
    //     //     case SpawnPointStrategyType.Linear:
    //     //         _spawnStrategy = new LinearSpawnStrategy(spawnPoints);
    //     //         break;
    //     //     case SpawnPointStrategyType.Random:
    //     //         _spawnStrategy = new RandomSpawnStrategy(spawnPoints);
    //     //         break;
    //     // }
    // }



    // }
}

