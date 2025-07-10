using Unity.Entities;

namespace Unity.Physics.GraphicsIntegration;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSystemGroup), OrderLast = true)]
public struct CopyPhysicsVelocityToSmoothing : ISystem, ISystemCompilerGenerated
{
    EntityQuery _SmoothedDynamicBodiesQuery_k__BackingField;
    EntityQuery SmoothedDynamicBodiesQuery;
    
    // unmanaged system, skipped generating example queries

}
