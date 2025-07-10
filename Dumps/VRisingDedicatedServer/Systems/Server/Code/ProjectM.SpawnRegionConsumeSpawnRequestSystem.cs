using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.ScheduleParentGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SpawnRegionConsumeSpawnRequestSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1303396448_0;
    
    // unmanaged system, skipped generating example queries

}
