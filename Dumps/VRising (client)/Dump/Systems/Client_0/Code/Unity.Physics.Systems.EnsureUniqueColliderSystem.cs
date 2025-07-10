using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSystemGroup))]
[UpdateAfter(typeof(Unity.Physics.Systems.AfterPhysicsSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct EnsureUniqueColliderSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_700693932_0;
    
    // unmanaged system, skipped generating example queries

}
