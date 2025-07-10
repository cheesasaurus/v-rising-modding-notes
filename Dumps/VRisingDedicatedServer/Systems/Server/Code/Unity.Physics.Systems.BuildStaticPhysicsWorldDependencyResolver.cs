using Unity.Entities;

namespace Unity.Physics.Systems;


[UpdateInGroup(typeof(FixedStepSimulationSystemGroup))]
[UpdateBefore(typeof(Unity.Physics.Systems.BuildStaticPhysicsWorld))]
[CreateAfter(typeof(Unity.Physics.Systems.BuildStaticPhysicsWorld))]
[DisableAutoCreation]
public struct BuildStaticPhysicsWorldDependencyResolver : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1935187857_0;
    
    // unmanaged system, skipped generating example queries

}
