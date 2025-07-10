using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaRuleSyncSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ArenaRuleBufferUpdatedQuery;
    EntityQuery __query_329949506_0;
    
    // unmanaged system, skipped generating example queries

}
