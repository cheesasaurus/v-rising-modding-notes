using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(ProjectM.BuildModeGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRoutePathRequestSystem : ISystem, ISystemCompilerGenerated, ISystemStartStop
{
    EntityQuery __query_1038473193_0;
    EntityQuery __query_1038473193_1;
    EntityQuery __query_1038473193_2;
    EntityQuery __query_1038473193_3;
    EntityQuery __query_1038473193_4;
    EntityQuery __query_1038473193_5;
    EntityQuery __query_1038473193_6;
    
    // unmanaged system, skipped generating example queries

}
