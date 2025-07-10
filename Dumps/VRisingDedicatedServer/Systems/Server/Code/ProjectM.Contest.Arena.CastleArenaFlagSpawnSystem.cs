using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaFlagSpawnSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1034016481_0;
    EntityQuery __query_1034016481_1;
    
    // unmanaged system, skipped generating example queries

}
