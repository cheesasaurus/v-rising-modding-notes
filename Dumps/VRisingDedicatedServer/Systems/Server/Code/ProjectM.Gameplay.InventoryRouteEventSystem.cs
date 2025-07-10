using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRouteEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _EventQuery;
    EntityQuery __query_2048370412_0;
    EntityQuery __query_2048370412_1;
    EntityQuery __query_2048370412_2;
    EntityQuery __query_2048370412_3;
    EntityQuery __query_2048370412_4;
    
    // unmanaged system, skipped generating example queries

}
