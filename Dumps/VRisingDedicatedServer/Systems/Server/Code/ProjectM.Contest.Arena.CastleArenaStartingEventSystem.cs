using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToContestEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaStartingEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ArenaStartingEventQuery;
    EntityQuery __query_2009269356_0;
    EntityQuery __query_2009269356_1;
    EntityQuery __query_2009269356_2;
    
    // unmanaged system, skipped generating example queries

}
