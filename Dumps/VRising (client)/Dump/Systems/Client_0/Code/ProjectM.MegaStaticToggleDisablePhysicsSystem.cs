using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.CollisionGroup))]
[UpdateBefore(typeof(FixedStepSimulationSystemGroup))]
public struct MegaStaticToggleDisablePhysicsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_287427570_0;
    EntityQuery __query_287427570_1;
    
    // unmanaged system, skipped generating example queries

}
