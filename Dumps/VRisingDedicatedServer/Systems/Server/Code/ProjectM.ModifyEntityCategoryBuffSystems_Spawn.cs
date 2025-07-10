using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyEntityCategoryBuffSystems_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_335831772_0;
    EntityQuery __query_335831772_1;
    
    // unmanaged system, skipped generating example queries

}
