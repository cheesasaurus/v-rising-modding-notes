using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ArenaSyncParentSpawnInstance_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_2082047437_0;
    EntityQuery __query_2082047437_1;
    
    // unmanaged system, skipped generating example queries

}
