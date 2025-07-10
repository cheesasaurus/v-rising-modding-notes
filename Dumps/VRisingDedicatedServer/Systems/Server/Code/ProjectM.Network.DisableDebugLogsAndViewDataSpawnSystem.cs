using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DisableDebugLogsAndViewDataSpawnSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_588674715_0;
    
    // unmanaged system, skipped generating example queries

}
