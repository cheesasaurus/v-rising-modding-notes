using Unity.Entities;

namespace ProjectM.Contest.Duel;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DuelFlagSpawnSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_448354673_0;
    EntityQuery __query_448354673_1;
    
    // unmanaged system, skipped generating example queries

}
