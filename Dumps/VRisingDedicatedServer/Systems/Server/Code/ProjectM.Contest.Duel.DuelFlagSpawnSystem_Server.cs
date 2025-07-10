using Unity.Entities;

namespace ProjectM.Contest.Duel;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DuelFlagSpawnSystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_448354625_0;
    EntityQuery __query_448354625_1;
    
    // unmanaged system, skipped generating example queries

}
