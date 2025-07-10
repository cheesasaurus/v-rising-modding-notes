using Unity.Entities;

namespace ProjectM.Contest.Duel;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct VBloodDuelActivateSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _BossesQuery;
    EntityQuery _Query;
    EntityQuery __query_2029312160_0;
    
    // unmanaged system, skipped generating example queries

}
