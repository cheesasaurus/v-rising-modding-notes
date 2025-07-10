using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UnitMountBuffShareSystem_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _BuffQuery;
    EntityQuery _MountQuery;
    EntityQuery __query_1987576622_0;
    EntityQuery __query_1987576622_1;
    EntityQuery __query_1987576622_2;
    
    // unmanaged system, skipped generating example queries

}
