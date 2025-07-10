using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[UpdateBefore(typeof(ProjectM.Network.PrioritizeSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SyncToUserBitMaskSystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_588674649_0;
    EntityQuery __query_588674649_1;
    
    // unmanaged system, skipped generating example queries

}
