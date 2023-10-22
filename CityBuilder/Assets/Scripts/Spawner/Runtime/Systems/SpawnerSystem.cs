using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

namespace Spawner.Runtime
{
    public partial struct SpawnerSystem : ISystem
    {
        public void OnCreate(ref SystemState state)
        {
            
        }

        public void OnDestroy(ref SystemState state)
        {
            
        }

        public void OnUpdate(ref SystemState state)
        {
            var bufferSingleton = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem .Singleton>();
            EntityCommandBuffer commandBuffer = bufferSingleton.CreateCommandBuffer(state.WorldUnmanaged);

            foreach (var spawner in SystemAPI.Query<RefRW<SpawnerComponent>>())
            {
                spawner.ValueRW.timeToNextSpawn -= SystemAPI.Time.DeltaTime;
                if (spawner.ValueRO.timeToNextSpawn < 0)
                {
                    spawner.ValueRW.timeToNextSpawn = spawner.ValueRO.timer;
                    Entity entity = commandBuffer.Instantiate(spawner.ValueRO.prefab);
                }
            }
        }
        
        
    }
}
