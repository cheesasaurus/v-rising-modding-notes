using Unity.Entities;

namespace ProjectM.Shared;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[UpdateBefore(typeof(ProjectM.Network.PrioritizeSystem))]
[UpdateAfter(typeof(ProjectM.Network.SyncToUserBitMaskSystem_Update))]
[RequireMatchingQueriesForUpdateAttribute]
public struct WarEventNetworkingSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_496164299_0;
    EntityQuery __query_496164299_1;
    EntityQuery __query_496164299_2;
    
    // unmanaged system, skipped generating example queries

}
