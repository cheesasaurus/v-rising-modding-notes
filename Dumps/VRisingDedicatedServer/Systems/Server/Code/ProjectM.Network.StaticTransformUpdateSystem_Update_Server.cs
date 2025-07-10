using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateBefore(typeof(ProjectM.CollisionGroup))]
[UpdateAfter(typeof(ProjectM.SerializeBarrier))]
[RequireMatchingQueriesForUpdateAttribute]
public struct StaticTransformUpdateSystem_Update_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery _UpdateStaticTransformQuery;
    
    // unmanaged system, skipped generating example queries

}
