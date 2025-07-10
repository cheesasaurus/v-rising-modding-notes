using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyTargetHudBuffSystems_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1247191054_0;
    EntityQuery __query_1247191054_1;
    
    // unmanaged system, skipped generating example queries

}
