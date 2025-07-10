using Unity.Entities;

namespace ProjectM.Contest.Duel;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DuelAiSystem_ReactToSpawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_682117503_0;
    
    // unmanaged system, skipped generating example queries

}
