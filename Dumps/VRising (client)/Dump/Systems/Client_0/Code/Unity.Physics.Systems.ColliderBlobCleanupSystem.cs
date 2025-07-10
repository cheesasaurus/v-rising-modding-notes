using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ColliderBlobCleanupSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery m_ColliderBlobCleanupGroup;
    EntityQuery __query_742850220_0;
    
    // unmanaged system, skipped generating example queries

}
