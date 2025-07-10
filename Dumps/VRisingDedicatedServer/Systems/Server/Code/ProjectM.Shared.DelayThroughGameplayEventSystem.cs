using Unity.Entities;

namespace ProjectM.Shared;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DelayThroughGameplayEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1210546134_0;
    EntityQuery __query_1210546134_1;
    EntityQuery __query_1210546134_2;
    
    // unmanaged system, skipped generating example queries

}
