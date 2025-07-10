using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaFlagDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1034016517_0;
    
    // unmanaged system, skipped generating example queries

}
