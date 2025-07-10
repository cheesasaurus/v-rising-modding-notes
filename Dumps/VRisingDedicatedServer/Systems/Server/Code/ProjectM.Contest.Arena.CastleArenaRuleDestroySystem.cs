using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaRuleDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_329949472_0;
    
    // unmanaged system, skipped generating example queries

}
