using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyConsumeBloodTypeBuffSystems_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1851245369_0;
    EntityQuery __query_1851245369_1;
    
    // unmanaged system, skipped generating example queries

}
