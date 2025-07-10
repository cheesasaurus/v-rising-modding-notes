using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRouteStationSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _StationQuery;
    EntityQuery __query_295623295_0;
    EntityQuery __query_295623295_1;
    
    // unmanaged system, skipped generating example queries

}
