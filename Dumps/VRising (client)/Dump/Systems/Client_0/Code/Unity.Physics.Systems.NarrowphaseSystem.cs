using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsCreateContactsGroup))]
[CreateAfter(typeof(Unity.Physics.Systems.PhysicsInitializeGroup))]
public struct NarrowphaseSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery m_PhysicsColliderQuery;
    EntityQuery __query_1568664298_0;
    EntityQuery __query_1568664298_1;
    EntityQuery __query_1568664298_2;
    
    // unmanaged system, skipped generating example queries

}
