using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UpdateCachedFaction : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_57018094_0;
    EntityQuery __query_57018094_1;
    EntityQuery __query_57018094_2;
    
    // unmanaged system, skipped generating example queries

}
