using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DelayedAggroEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1221820569_0;
    EntityQuery __query_1221820569_1;
    
    // unmanaged system, skipped generating example queries

}
