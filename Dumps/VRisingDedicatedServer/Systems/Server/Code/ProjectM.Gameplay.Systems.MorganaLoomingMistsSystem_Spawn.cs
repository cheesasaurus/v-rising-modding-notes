using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MorganaLoomingMistsSystem_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _CombatTagBuffSpawnQuery;
    EntityQuery _MistsBuffSpawnQuery;
    EntityQuery __query_1134205242_0;
    EntityQuery __query_1134205242_1;
    EntityQuery __query_1134205242_2;
    EntityQuery __query_1134205242_3;
    
    // unmanaged system, skipped generating example queries

}
