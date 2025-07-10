using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsInitializeGroupInternal), OrderFirst = true)]
[CreateAfter(typeof(Unity.Physics.Systems.BuildPhysicsWorld))]
public struct BuildPhysicsWorldDependencyResolver : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1843366491_0;
    EntityQuery __query_1843366491_1;
    
    // unmanaged system, skipped generating example queries

}
