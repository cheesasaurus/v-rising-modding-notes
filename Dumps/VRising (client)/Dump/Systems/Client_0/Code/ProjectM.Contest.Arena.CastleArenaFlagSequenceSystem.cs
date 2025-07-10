using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaFlagSequenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _OccupiedSlotsChangedQuery;
    EntityQuery _FlagMovedQuery;
    EntityQuery __query_1034016944_0;
    EntityQuery __query_1034016944_1;
    EntityQuery __query_1034016944_2;
    
    // unmanaged system, skipped generating example queries

}
