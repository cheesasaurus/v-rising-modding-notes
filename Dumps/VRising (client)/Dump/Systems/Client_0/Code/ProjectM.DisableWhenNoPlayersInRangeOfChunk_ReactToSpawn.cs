using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
public struct DisableWhenNoPlayersInRangeOfChunk_ReactToSpawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1408750095_0;
    EntityQuery __query_1408750095_1;
    EntityQuery __query_1408750095_2;
    
    // unmanaged system, skipped generating example queries

}
