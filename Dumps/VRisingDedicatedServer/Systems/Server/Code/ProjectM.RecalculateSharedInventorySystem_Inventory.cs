using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToInventoryChangedEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RecalculateSharedInventorySystem_Inventory : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_614110990_0;
    EntityQuery __query_614110990_1;
    EntityQuery __query_614110990_2;
    
    // unmanaged system, skipped generating example queries

}
