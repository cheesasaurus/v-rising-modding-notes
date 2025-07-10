using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRouteDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _RouteDestroyQuery;
    EntityQuery __query_2048370695_0;
    EntityQuery __query_2048370695_1;
    EntityQuery __query_2048370695_2;
    
    // unmanaged system, skipped generating example queries

}
