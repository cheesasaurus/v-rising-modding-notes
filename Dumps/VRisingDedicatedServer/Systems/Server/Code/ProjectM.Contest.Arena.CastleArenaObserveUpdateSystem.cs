using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.ReactToContestEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaObserveUpdateSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ContestQuery;
    EntityQuery _ObserveBuffQuery;
    EntityQuery __query_1167104289_0;
    EntityQuery __query_1167104289_1;
    EntityQuery __query_1167104289_2;
    
    // unmanaged system, skipped generating example queries

}
