using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[UpdateAfter(typeof(ProjectM.ScaleWithBloodEfficiencySystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyUnitStatBuffSystem_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_35557666_0;
    EntityQuery __query_35557666_1;
    
    // unmanaged system, skipped generating example queries

}
