using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRouteStationEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ClearEventQuery;
    EntityQuery __query_295623243_0;
    EntityQuery __query_295623243_1;
    EntityQuery __query_295623243_2;
    
    // unmanaged system, skipped generating example queries

}
