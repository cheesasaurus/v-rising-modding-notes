using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaRuleSpawnSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_329949428_0;
    EntityQuery __query_329949428_1;
    
    // unmanaged system, skipped generating example queries

}
