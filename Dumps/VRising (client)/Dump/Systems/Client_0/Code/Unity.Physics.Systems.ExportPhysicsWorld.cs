using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(Unity.Physics.Systems.PhysicsSystemGroup))]
[UpdateAfter(typeof(Unity.Physics.Systems.PhysicsSimulationGroup))]
[CreateAfter(typeof(Unity.Physics.Systems.BuildPhysicsWorld))]
public struct ExportPhysicsWorld : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1345676170_0;
    
    // unmanaged system, skipped generating example queries

}
