using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
[UpdateBefore(typeof(ProjectM.AggroSystem))]
[UpdateBefore(typeof(ProjectM.AlertSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct GatherAggroCandidatesSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1326205902_0;
    EntityQuery __query_1326205902_1;
    EntityQuery __query_1326205902_2;
    EntityQuery __query_1326205902_3;
    
    // unmanaged system, skipped generating example queries

}
