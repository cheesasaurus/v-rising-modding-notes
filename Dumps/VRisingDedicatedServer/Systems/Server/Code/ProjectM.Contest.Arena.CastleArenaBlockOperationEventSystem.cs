using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.Contest.Arena.CastleArenaBoundsSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaBlockOperationEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _BlockOperationEventQuery;
    EntityQuery __query_329949226_0;
    EntityQuery __query_329949226_1;
    EntityQuery __query_329949226_2;
    
    // unmanaged system, skipped generating example queries

}
