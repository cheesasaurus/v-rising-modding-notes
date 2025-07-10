using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyUnitBaseStatsTypeBuffsSystems_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_294634896_0;
    EntityQuery __query_294634896_1;
    
    // unmanaged system, skipped generating example queries

}
