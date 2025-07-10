using Unity.Entities;

namespace Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct VampireAttributeSystem_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_2123997107_0;
    EntityQuery __query_2123997107_1;
    EntityQuery __query_2123997107_2;
    
    // unmanaged system, skipped generating example queries

}
