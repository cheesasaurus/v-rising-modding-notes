using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaFlagBuffDestroySystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1034016655_0;
    
    // unmanaged system, skipped generating example queries

}
