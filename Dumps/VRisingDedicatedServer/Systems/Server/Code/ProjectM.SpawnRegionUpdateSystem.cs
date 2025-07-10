using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ScheduleGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SpawnRegionUpdateSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1303396349_0;
    EntityQuery __query_1303396349_1;
    
    // unmanaged system, skipped generating example queries

}
