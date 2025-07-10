using Unity.Entities;

namespace ProjectM.Behaviours;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyBehaviourBuffSystem_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_168487773_0;
    EntityQuery __query_168487773_1;
    EntityQuery __query_168487773_2;
    
    // unmanaged system, skipped generating example queries

}
