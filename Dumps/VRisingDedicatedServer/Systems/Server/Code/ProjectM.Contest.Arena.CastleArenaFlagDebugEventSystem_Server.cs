using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaFlagDebugEventSystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery _EventQuery;
    EntityQuery __query_1034016864_0;
    EntityQuery __query_1034016864_1;
    EntityQuery __query_1034016864_2;
    
    // unmanaged system, skipped generating example queries

}
