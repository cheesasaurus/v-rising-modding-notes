using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaFlagBuffUpdateSystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery _FlagBuffQuery;
    EntityQuery __query_1034016582_0;
    EntityQuery __query_1034016582_1;
    
    // unmanaged system, skipped generating example queries

}
