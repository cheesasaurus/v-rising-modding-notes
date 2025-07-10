using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaUpdateFlagStatusSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _UpdatedArenaContestOwnerQuery;
    EntityQuery __query_1726780559_0;
    
    // unmanaged system, skipped generating example queries

}
