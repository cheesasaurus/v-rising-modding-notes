using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleActiveArenaSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _CastleArenaQuery;
    EntityQuery __query_329949148_0;
    EntityQuery __query_329949148_1;
    EntityQuery __query_329949148_2;
    EntityQuery __query_329949148_3;
    EntityQuery __query_329949148_4;
    EntityQuery __query_329949148_5;
    
    // unmanaged system, skipped generating example queries

}
