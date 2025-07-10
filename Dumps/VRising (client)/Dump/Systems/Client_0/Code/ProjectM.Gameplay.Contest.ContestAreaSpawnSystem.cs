using Unity.Entities;

namespace ProjectM.Gameplay.Contest;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ContestAreaSpawnSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ContestAreaSpawnQuery;
    EntityQuery __query_2119395370_0;
    EntityQuery __query_2119395370_1;
    
    // unmanaged system, skipped generating example queries

}
