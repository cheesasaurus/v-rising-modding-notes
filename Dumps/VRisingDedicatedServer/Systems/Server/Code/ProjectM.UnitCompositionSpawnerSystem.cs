using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.ScheduleParentGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UnitCompositionSpawnerSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _PlayerQuery;
    EntityQuery __query_707728837_0;
    EntityQuery __query_707728837_1;
    EntityQuery __query_707728837_2;
    EntityQuery __query_707728837_3;
    EntityQuery __query_707728837_4;
    EntityQuery __query_707728837_5;
    EntityQuery __query_707728837_6;
    
    // unmanaged system, skipped generating example queries

}
