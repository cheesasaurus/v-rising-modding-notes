using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetupInitialStatesGroup_Step2))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ProjectileSystem_Spawn_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1963200447_0;
    EntityQuery __query_1963200447_1;
    EntityQuery __query_1963200447_2;
    EntityQuery __query_1963200447_3;
    
    // unmanaged system, skipped generating example queries

}
