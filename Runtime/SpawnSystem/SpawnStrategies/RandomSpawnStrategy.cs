using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Holypastry.Bakery
{
    public class RandomSpawnStrategy : ISpawnStrategy
    {

        List<Transform> unusedSpawnPoints = new();
        Transform[] spawnPoints;

        public RandomSpawnStrategy(Transform[] spawnPoints)
        {
            this.spawnPoints = spawnPoints;
            unusedSpawnPoints.AddRange(spawnPoints);
        }

        public Transform NextSpawnPoint()
        {
            if (!unusedSpawnPoints.Any())
                unusedSpawnPoints = new(spawnPoints);

            Transform result = unusedSpawnPoints.Random();
            unusedSpawnPoints.Remove(result);
            return result;
        }

    }
}
