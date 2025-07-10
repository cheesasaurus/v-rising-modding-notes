using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.AfterDeserializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct TimeoutSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_64288991_0;
    
    // unmanaged system, skipped generating example queries

}
