using Unity.Entities;

namespace ProjectM.Contest;


[UpdateInGroup(typeof(ProjectM.ReactToContestEventGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct ContestInstanceEventCleanupSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ContestEventQuery;
    EntityQuery __query_801697365_0;
    
    // unmanaged system, skipped generating example queries

}
