using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSystemGroup))]
[UpdateBefore(typeof(Unity.Physics.Systems.PhysicsInitializeGroup))]
public struct SyncCustomPhysicsProxySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery m_Query;
    EntityQuery __query_645183514_0;
    
    // unmanaged system, skipped generating example queries

}
