using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UnitCompositionSpawnerSystem_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_707728685_0;
    EntityQuery __query_707728685_1;
    
    // unmanaged system, skipped generating example queries

}
