using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsCreateBodyPairsGroup))]
[CreateAfter(typeof(Unity.Physics.Systems.PhysicsInitializeGroup))]
public struct BroadphaseSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery m_PhysicsColliderQuery;
    EntityQuery __query_1568664232_0;
    EntityQuery __query_1568664232_1;
    EntityQuery __query_1568664232_2;
    EntityQuery __query_1568664232_3;
    EntityQuery __query_1568664232_4;
    
    // unmanaged system, skipped generating example queries

}
