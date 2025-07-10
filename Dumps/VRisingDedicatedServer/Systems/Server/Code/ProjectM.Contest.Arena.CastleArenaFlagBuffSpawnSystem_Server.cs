using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaFlagBuffSpawnSystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1034016541_0;
    
    // unmanaged system, skipped generating example queries

}
