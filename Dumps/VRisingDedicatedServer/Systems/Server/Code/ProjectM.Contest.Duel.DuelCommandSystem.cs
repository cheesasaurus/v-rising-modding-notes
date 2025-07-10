using Unity.Entities;

namespace ProjectM.Contest.Duel;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DuelCommandSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _InstantiateDuelQuery;
    EntityQuery _JoinDuelQuery;
    EntityQuery __query_1431704317_0;
    EntityQuery __query_1431704317_1;
    EntityQuery __query_1431704317_2;
    EntityQuery __query_1431704317_3;
    EntityQuery __query_1431704317_4;
    EntityQuery __query_1431704317_5;
    EntityQuery __query_1431704317_6;
    EntityQuery __query_1431704317_7;
    
    // unmanaged system, skipped generating example queries

}
