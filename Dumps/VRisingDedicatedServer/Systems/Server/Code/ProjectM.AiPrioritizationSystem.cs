using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
[UpdateBefore(typeof(ProjectM.GatherAggroCandidatesSystem))]
public struct AiPrioritizationSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2018569555_0;
    EntityQuery __query_2018569555_1;
    EntityQuery __query_2018569555_2;
    EntityQuery __query_2018569555_3;
    EntityQuery __query_2018569555_4;
    
    // unmanaged system, skipped generating example queries

}
