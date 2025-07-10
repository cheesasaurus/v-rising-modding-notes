using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToContestEventGroup))]
[UpdateAfter(typeof(ProjectM.Contest.Arena.CastleArenaDefeatedEventSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaEndingEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ArenaFinishedEventQuery;
    EntityQuery _ArenaCancelledEventQuery;
    EntityQuery __query_2009269436_0;
    EntityQuery __query_2009269436_1;
    EntityQuery __query_2009269436_2;
    EntityQuery __query_2009269436_3;
    EntityQuery __query_2009269436_4;
    
    // unmanaged system, skipped generating example queries

}
