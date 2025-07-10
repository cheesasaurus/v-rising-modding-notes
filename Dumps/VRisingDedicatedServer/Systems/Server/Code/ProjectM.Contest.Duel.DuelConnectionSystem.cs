using Unity.Entities;

namespace ProjectM.Contest.Duel;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct DuelConnectionSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_448354522_0;
    EntityQuery __query_448354522_1;
    EntityQuery __query_448354522_2;
    
    // unmanaged system, skipped generating example queries

}
