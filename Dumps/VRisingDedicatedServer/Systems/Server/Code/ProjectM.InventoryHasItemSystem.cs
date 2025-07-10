using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToInventoryChangedEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryHasItemSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_710171083_0;
    
    // unmanaged system, skipped generating example queries

}
