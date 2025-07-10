using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsCreateJacobiansGroup))]
[CreateAfter(typeof(Unity.Physics.Systems.PhysicsInitializeGroup))]
public struct CreateJacobiansSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery m_PhysicsColliderQuery;
    EntityQuery __query_1568664327_0;
    EntityQuery __query_1568664327_1;
    EntityQuery __query_1568664327_2;
    
    // unmanaged system, skipped generating example queries

}
