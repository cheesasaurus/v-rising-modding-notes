using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[UpdateBefore(typeof(ProjectM.Network.PrioritizeSystem))]
[UpdateAfter(typeof(ProjectM.Network.SyncToUserBitMaskSystem_Update))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UpdateAdminDebugSyncSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_588674680_0;
    EntityQuery __query_588674680_1;
    EntityQuery __query_588674680_2;
    
    // unmanaged system, skipped generating example queries

}
