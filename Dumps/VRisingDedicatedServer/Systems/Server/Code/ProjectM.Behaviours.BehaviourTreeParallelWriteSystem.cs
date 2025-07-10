using Unity.Entities;

namespace ProjectM.Behaviours;


[UpdateInGroup(typeof(ProjectM.AiGroup), OrderLast = true)]
[UpdateAfter(typeof(ProjectM.AiSubGroup1))]
[RequireMatchingQueriesForUpdateAttribute]
public struct BehaviourTreeParallelWriteSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2061274547_0;
    EntityQuery __query_2061274547_1;
    
    // unmanaged system, skipped generating example queries

}
