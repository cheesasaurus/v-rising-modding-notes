using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup), OrderFirst = true)]
[UpdateBefore(typeof(ProjectM.PrefabCollectionSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CleanupInvalidRegisterPrefabRequests : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_216177116_0;
    
    // unmanaged system, skipped generating example queries

}
