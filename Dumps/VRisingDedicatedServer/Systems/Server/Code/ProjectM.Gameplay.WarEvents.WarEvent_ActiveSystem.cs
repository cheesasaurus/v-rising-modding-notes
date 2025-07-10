using Unity.Entities;

namespace ProjectM.Gameplay.WarEvents;


[UpdateInGroup(typeof(ProjectM.Gameplay.WarEvents.WarEventUpdateGroup))]
[UpdateAfter(typeof(ProjectM.Gameplay.WarEvents.WarEventSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct WarEvent_ActiveSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1697775537_0;
    EntityQuery __query_1697775537_1;
    EntityQuery __query_1697775537_2;
    EntityQuery __query_1697775537_3;
    EntityQuery __query_1697775537_4;
    EntityQuery __query_1697775537_5;
    EntityQuery __query_1697775537_6;
    EntityQuery __query_1697775537_7;
    EntityQuery __query_1697775537_8;
    EntityQuery __query_1697775537_9;
    EntityQuery __query_1697775537_10;
    EntityQuery __query_1697775537_11;
    EntityQuery __query_1697775537_12;
    
    // unmanaged system, skipped generating example queries

}
