using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.GetHybridDataGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.GetHybridModelLocomotionSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct GetHybridModelAnimationSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1866983668_0;
    EntityQuery __query_1866983668_1;
    
    // unmanaged system, skipped generating example queries

}
