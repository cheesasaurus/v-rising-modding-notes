using Unity.Entities;

namespace ProjectM.Behaviours;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
[UpdateBefore(typeof(ProjectM.AiMoveSystem_Server))]
[RequireMatchingQueriesForUpdateAttribute]
public struct BehaviourTreeSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _CleanupDeadBehaviourTreeQuery;
    EntityQuery _CastleWorkstationQuery;
    EntityQuery _AiDamageTakenEventQuery;
    EntityQuery __query_1260020681_0;
    EntityQuery __query_1260020681_1;
    EntityQuery __query_1260020681_2;
    EntityQuery __query_1260020681_3;
    EntityQuery __query_1260020681_4;
    EntityQuery __query_1260020681_5;
    EntityQuery __query_1260020681_6;
    EntityQuery __query_1260020681_7;
    EntityQuery __query_1260020681_8;
    EntityQuery __query_1260020681_9;
    
    // unmanaged system, skipped generating example queries

}
