using Unity.Entities;

namespace ProjectM.Contest;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ContestSystem_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1326370176_0;
    EntityQuery __query_1326370176_1;
    EntityQuery __query_1326370176_2;
    
    // unmanaged system, skipped generating example queries

}
