using Unity.Entities;

namespace ProjectM.Gameplay.WarEvents;


[UpdateInGroup(typeof(ProjectM.Gameplay.WarEvents.WarEventUpdateGroup))]
[UpdateAfter(typeof(ProjectM.Gameplay.WarEvents.WarEvent_ActiveSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct WarEvent_GateSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1931049362_0;
    EntityQuery __query_1931049362_1;
    EntityQuery __query_1931049362_2;
    EntityQuery __query_1931049362_3;
    EntityQuery __query_1931049362_4;
    EntityQuery __query_1931049362_5;
    EntityQuery __query_1931049362_6;
    EntityQuery __query_1931049362_7;
    EntityQuery __query_1931049362_8;
    EntityQuery __query_1931049362_9;
    
    // unmanaged system, skipped generating example queries

}
