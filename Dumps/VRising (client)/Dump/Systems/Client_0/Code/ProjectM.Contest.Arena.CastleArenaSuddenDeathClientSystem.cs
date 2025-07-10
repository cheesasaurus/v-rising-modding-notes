using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaSuddenDeathClientSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _SuddenDeathQuery;
    EntityQuery __query_329949545_0;
    EntityQuery __query_329949545_1;
    EntityQuery __query_329949545_2;
    EntityQuery __query_329949545_3;
    EntityQuery __query_329949545_4;
    
    // unmanaged system, skipped generating example queries

}
