using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.ReactToInventoryChangedEventGroup))]
[UpdateAfter(typeof(ProjectM.Gameplay.InventoryRoute_ReactToInventoryChanged))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRoute_RecalculateInventoryRouteAvailability : ISystem, ISystemCompilerGenerated
{
    EntityQuery _EventQuery;
    EntityQuery __query_2048370869_0;
    
    // unmanaged system, skipped generating example queries

}
