using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaStationRuleEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _RuleEventQuery;
    EntityQuery __query_1726780462_0;
    EntityQuery __query_1726780462_1;
    
    // unmanaged system, skipped generating example queries

}
