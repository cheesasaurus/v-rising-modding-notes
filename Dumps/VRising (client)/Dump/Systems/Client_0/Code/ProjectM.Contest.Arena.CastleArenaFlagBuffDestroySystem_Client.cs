using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaFlagBuffDestroySystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _DestroyFlagBuffQuery;
    EntityQuery __query_1034016742_0;
    
    // unmanaged system, skipped generating example queries

}
