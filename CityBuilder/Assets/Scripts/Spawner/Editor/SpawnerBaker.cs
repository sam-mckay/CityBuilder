using System.Collections;
using System.Collections.Generic;
using Spawner.Runtime;
using Unity.Entities;
using UnityEngine;

namespace Spawner.Editor
{
    public class SpawnerBaker : Baker<SpawnerAuthoring>
    {
        public override void Bake(SpawnerAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            SpawnerComponent spawner = new SpawnerComponent()
            {
                prefab = GetEntity(authoring.prefab, TransformUsageFlags.Dynamic),
                timer = authoring.Timer,
                timeToNextSpawn = authoring.Timer
            };
            
            AddComponent(entity, spawner);
        }
    }
}
