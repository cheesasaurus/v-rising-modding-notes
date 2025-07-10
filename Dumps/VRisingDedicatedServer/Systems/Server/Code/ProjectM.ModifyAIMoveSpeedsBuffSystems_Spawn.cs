using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyAIMoveSpeedsBuffSystems_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1800736718_0;
    EntityQuery __query_1800736718_1;
    
    // unmanaged system, skipped generating example queries

}
