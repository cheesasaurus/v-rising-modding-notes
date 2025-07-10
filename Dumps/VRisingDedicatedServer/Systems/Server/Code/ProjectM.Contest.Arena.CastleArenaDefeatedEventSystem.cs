using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToContestEventGroup))]
[UpdateAfter(typeof(ProjectM.Contest.Arena.CastleArenaStartingEventSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaDefeatedEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ParticipantDefeatedEventQuery;
    EntityQuery __query_2009269396_0;
    EntityQuery __query_2009269396_1;
    
    // unmanaged system, skipped generating example queries

}
