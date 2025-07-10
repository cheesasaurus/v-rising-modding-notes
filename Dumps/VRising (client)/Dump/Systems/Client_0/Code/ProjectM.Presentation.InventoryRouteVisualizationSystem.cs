using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRouteVisualizationSystem : ISystem, ISystemCompilerGenerated, ISystemStartStop
{
    EntityQuery __query_758092165_0;
    EntityQuery __query_758092165_1;
    EntityQuery __query_758092165_2;
    EntityQuery __query_758092165_3;
    EntityQuery __query_758092165_4;
    EntityQuery __query_758092165_5;
    
    // unmanaged system, skipped generating example queries

}
