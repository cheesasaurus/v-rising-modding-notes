using Unity.Entities;

namespace ProjectM.Contest;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.ReactToContestEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ContestSystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ContestQuery;
    EntityQuery __query_1804803052_0;
    EntityQuery __query_1804803052_1;
    EntityQuery __query_1804803052_2;
    EntityQuery __query_1804803052_3;
    
    // unmanaged system, skipped generating example queries

}
