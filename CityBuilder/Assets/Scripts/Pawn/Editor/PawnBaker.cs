using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;


namespace Pawn.Editor
{
    public class PawnBaker : Baker<PawnAuthoring>
    {
        public override void Bake(PawnAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            
            AddComponent(entity, new Runtime.Pawn
            {
                pawnType = authoring.pawnType
            });
        }
    }
}
