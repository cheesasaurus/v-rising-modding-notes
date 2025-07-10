using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct NetworkInterpolationSystem_MountSpawnServer : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1748990297_0;
    
    // unmanaged system, skipped generating example queries

}
