using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(ProjectM.ScheduleGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRoutePathJobSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _PathJobQuery;
    EntityQuery _PathUpdateQuery;
    EntityQuery __query_1038473405_0;
    EntityQuery __query_1038473405_1;
    EntityQuery __query_1038473405_2;
    EntityQuery __query_1038473405_3;
    EntityQuery __query_1038473405_4;
    EntityQuery __query_1038473405_5;
    EntityQuery __query_1038473405_6;
    EntityQuery __query_1038473405_7;
    
    // unmanaged system, skipped generating example queries

}
