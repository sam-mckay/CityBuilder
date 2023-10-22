using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

namespace Pawn.Runtime
{
    public struct Pawn : IComponentData
    {
        public PawnType pawnType;
    }
    
    public struct TransportPawnTag : IComponentData
    {
        
    }
}
