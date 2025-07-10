using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiSubGroup2))]
[UpdateBefore(typeof(ProjectM.KillAllMinionsEventSystem))]
[UpdateAfter(typeof(ProjectM.Behaviours.BehaviourTreeStateChangedEventSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ResetAiThingsOnEnterIdleSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1102198350_0;
    
    // unmanaged system, skipped generating example queries

}
