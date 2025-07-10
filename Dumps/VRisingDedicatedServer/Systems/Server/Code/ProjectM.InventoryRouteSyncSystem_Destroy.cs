using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRouteSyncSystem_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_572055678_0;
    EntityQuery __query_572055678_1;
    
    // unmanaged system, skipped generating example queries

}
