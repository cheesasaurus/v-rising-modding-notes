using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public struct InventoryRouteSyncUserSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ChangedSingletonQuery;
    EntityQuery __query_572055529_0;
    EntityQuery __query_572055529_1;
    
    // unmanaged system, skipped generating example queries

}
