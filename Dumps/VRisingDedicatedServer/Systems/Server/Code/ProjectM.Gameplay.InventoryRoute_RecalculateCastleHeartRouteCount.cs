using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRoute_RecalculateCastleHeartRouteCount : ISystem, ISystemCompilerGenerated
{
    EntityQuery _EventQuery;
    EntityQuery __query_2048370931_0;
    EntityQuery __query_2048370931_1;
    EntityQuery __query_2048370931_2;
    
    // unmanaged system, skipped generating example queries

}
