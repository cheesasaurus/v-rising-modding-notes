using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct StablesSystem_MountSequences : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1751579567_0;
    EntityQuery __query_1751579567_1;
    
    // unmanaged system, skipped generating example queries

}
