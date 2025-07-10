using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaStationDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _DestroyQuery;
    EntityQuery __query_1726780280_0;
    EntityQuery __query_1726780280_1;
    EntityQuery __query_1726780280_2;
    
    // unmanaged system, skipped generating example queries

}
