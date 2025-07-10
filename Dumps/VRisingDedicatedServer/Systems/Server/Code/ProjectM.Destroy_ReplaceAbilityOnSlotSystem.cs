using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct Destroy_ReplaceAbilityOnSlotSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1482480676_0;
    EntityQuery __query_1482480676_1;
    
    // unmanaged system, skipped generating example queries

}
