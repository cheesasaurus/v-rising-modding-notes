using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsInitializeGroupInternal), OrderLast = true)]
public struct BuildPhysicsWorld : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1843366573_0;
    EntityQuery __query_1843366573_1;
    
    // unmanaged system, skipped generating example queries

}
