using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToInventoryChangedEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryItemSyncSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_710171115_0;
    
    // unmanaged system, skipped generating example queries

}
