using Unity.Entities;

namespace ProjectM.Shared;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[UpdateBefore(typeof(ProjectM.Network.PrioritizeSystem))]
[UpdateAfter(typeof(ProjectM.Network.SyncToUserBitMaskSystem_Update))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RelicBoundMapIcon_SyncSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2106231998_0;
    EntityQuery __query_2106231998_1;
    EntityQuery __query_2106231998_2;
    EntityQuery __query_2106231998_3;
    EntityQuery __query_2106231998_4;
    EntityQuery __query_2106231998_5;
    
    // unmanaged system, skipped generating example queries

}
