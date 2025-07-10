using Unity.Entities;

namespace ProjectM.Contest.Duel;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.ReactToContestEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DuelSystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_108752185_0;
    EntityQuery __query_108752185_1;
    EntityQuery __query_108752185_2;
    EntityQuery __query_108752185_3;
    EntityQuery __query_108752185_4;
    
    // unmanaged system, skipped generating example queries

}
