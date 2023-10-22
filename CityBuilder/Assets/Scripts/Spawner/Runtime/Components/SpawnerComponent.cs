using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

namespace Spawner.Runtime
{
    public struct SpawnerComponent : IComponentData
    {
        public Entity prefab;
        public float timer;
        public float timeToNextSpawn;
    }
}
