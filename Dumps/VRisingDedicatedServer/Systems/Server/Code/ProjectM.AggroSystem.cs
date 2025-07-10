using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
[UpdateBefore(typeof(ProjectM.Behaviours.BehaviourTreeSystem))]
public struct AggroSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _InverseAggroEventsAddedQuery;
    EntityQuery _InverseAggroEventsRemovedQuery;
    EntityQuery __query_1991726892_0;
    EntityQuery __query_1991726892_1;
    
    // unmanaged system, skipped generating example queries

}
