using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
[UpdateBefore(typeof(ProjectM.GatherAggroCandidatesSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AggroDamageHistorySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1135035029_0;
    EntityQuery __query_1135035029_1;
    
    // unmanaged system, skipped generating example queries

}
