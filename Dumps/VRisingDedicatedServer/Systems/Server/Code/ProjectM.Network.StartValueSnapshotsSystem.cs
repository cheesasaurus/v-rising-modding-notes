using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct StartValueSnapshotsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _SnapshotQuery;
    EntityQuery _RegisterEventQuery;
    EntityQuery __query_476197683_0;
    EntityQuery __query_476197683_1;
    
    // unmanaged system, skipped generating example queries

}
