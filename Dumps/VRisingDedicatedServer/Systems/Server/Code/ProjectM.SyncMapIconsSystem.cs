using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[UpdateBefore(typeof(ProjectM.Network.PrioritizeSystem))]
[UpdateAfter(typeof(ProjectM.Network.SyncToUserBitMaskSystem_Update))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SyncMapIconsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1050583698_0;
    
    // unmanaged system, skipped generating example queries

}
