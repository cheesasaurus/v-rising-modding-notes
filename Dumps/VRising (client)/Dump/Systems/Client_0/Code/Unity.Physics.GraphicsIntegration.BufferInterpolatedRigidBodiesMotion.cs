using Unity.Entities;

namespace Unity.Physics.GraphicsIntegration;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSystemGroup))]
[UpdateBefore(typeof(Unity.Physics.Systems.ExportPhysicsWorld))]
[UpdateAfter(typeof(Unity.Physics.Systems.PhysicsInitializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct BufferInterpolatedRigidBodiesMotion : ISystem, ISystemCompilerGenerated
{
    EntityQuery _InterpolatedDynamicBodiesQuery_k__BackingField;
    EntityQuery InterpolatedDynamicBodiesQuery;
    
    // unmanaged system, skipped generating example queries

}
