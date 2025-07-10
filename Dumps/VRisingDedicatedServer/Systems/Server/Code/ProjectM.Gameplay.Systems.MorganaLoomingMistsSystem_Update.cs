using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MorganaLoomingMistsSystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery _CombatBuffQuery;
    EntityQuery _MistQuery;
    EntityQuery __query_1134205291_0;
    EntityQuery __query_1134205291_1;
    EntityQuery __query_1134205291_2;
    
    // unmanaged system, skipped generating example queries

}
