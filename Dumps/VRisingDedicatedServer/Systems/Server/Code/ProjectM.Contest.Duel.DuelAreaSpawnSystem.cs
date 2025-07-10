using Unity.Entities;

namespace ProjectM.Contest.Duel;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DuelAreaSpawnSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_448354705_0;
    
    // unmanaged system, skipped generating example queries

}
