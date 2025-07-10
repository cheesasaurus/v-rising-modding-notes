using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ArenaSyncParentDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2082047482_0;
    
    // unmanaged system, skipped generating example queries

}
