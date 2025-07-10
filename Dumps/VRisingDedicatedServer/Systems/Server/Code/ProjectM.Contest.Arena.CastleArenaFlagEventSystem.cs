using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaFlagEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _FlagEventQuery;
    EntityQuery __query_1034016789_0;
    
    // unmanaged system, skipped generating example queries

}
