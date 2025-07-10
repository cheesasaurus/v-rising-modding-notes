using Unity.Entities;

namespace ProjectM.Gameplay.WarEvents;


[UpdateInGroup(typeof(ProjectM.Gameplay.WarEvents.WarEventUpdateGroup))]
[UpdateAfter(typeof(ProjectM.Gameplay.WarEvents.WarEvent_GateSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct WarEvent_PortalSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1313273531_0;
    EntityQuery __query_1313273531_1;
    EntityQuery __query_1313273531_2;
    EntityQuery __query_1313273531_3;
    EntityQuery __query_1313273531_4;
    EntityQuery __query_1313273531_5;
    EntityQuery __query_1313273531_6;
    EntityQuery __query_1313273531_7;
    EntityQuery __query_1313273531_8;
    EntityQuery __query_1313273531_9;
    
    // unmanaged system, skipped generating example queries

}
