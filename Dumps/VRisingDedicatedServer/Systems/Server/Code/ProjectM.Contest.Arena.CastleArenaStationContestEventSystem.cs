using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaStationContestEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ContestEventQuery;
    EntityQuery __query_1726780330_0;
    EntityQuery __query_1726780330_1;
    EntityQuery __query_1726780330_2;
    EntityQuery __query_1726780330_3;
    
    // unmanaged system, skipped generating example queries

}
