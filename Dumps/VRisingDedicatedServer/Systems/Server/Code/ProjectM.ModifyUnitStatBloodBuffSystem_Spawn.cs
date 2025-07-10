using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[UpdateBefore(typeof(ProjectM.ModifyUnitStatBuffSystem_Spawn))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyUnitStatBloodBuffSystem_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_998822524_0;
    EntityQuery __query_998822524_1;
    
    // unmanaged system, skipped generating example queries

}
