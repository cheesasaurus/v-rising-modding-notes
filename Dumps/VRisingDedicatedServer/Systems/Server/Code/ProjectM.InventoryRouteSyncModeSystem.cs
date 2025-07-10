using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRouteSyncModeSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ModeEventQuery;
    EntityQuery __query_572055564_0;
    EntityQuery __query_572055564_1;
    EntityQuery __query_572055564_2;
    EntityQuery __query_572055564_3;
    
    // unmanaged system, skipped generating example queries

}
