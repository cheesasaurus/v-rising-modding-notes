using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
[UpdateBefore(typeof(ProjectM.AlertSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AggroEventsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _AddEventQuery;
    EntityQuery _RemoveEventQuery;
    EntityQuery _ClearEventQuery;
    EntityQuery _CopyEventQuery;
    EntityQuery __query_1991726686_0;
    EntityQuery __query_1991726686_1;
    EntityQuery __query_1991726686_2;
    EntityQuery __query_1991726686_3;
    EntityQuery __query_1991726686_4;
    EntityQuery __query_1991726686_5;
    EntityQuery __query_1991726686_6;
    EntityQuery __query_1991726686_7;
    EntityQuery __query_1991726686_8;
    
    // unmanaged system, skipped generating example queries

}
