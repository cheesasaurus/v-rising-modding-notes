using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SpellLevelSystem_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_934077457_0;
    EntityQuery __query_934077457_1;
    EntityQuery __query_934077457_2;
    
    // unmanaged system, skipped generating example queries

}
