using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct PathRecorderSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_199709401_0;
    
    // unmanaged system, skipped generating example queries

}
