using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[UpdateBefore(typeof(ProjectM.Network.PrioritizeSystem))]
[UpdateAfter(typeof(ProjectM.Network.SyncToUserBitMaskSystem_Update))]
[RequireMatchingQueriesForUpdateAttribute]
public struct PlayerCharacterSyncSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1545017948_0;
    EntityQuery __query_1545017948_1;
    
    // unmanaged system, skipped generating example queries

}
