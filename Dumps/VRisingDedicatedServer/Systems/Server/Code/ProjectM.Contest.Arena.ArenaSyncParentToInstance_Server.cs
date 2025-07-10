using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.Contest.Arena.ArenaSyncParentSpawnInstance_Server))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ArenaSyncParentToInstance_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2082047502_0;
    
    // unmanaged system, skipped generating example queries

}
