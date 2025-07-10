using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRouteSyncSystem_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _SyncBuffSpawnQuery;
    EntityQuery __query_572055632_0;
    EntityQuery __query_572055632_1;
    
    // unmanaged system, skipped generating example queries

}
