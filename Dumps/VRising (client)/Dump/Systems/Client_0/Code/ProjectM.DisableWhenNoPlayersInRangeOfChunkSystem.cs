using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
public struct DisableWhenNoPlayersInRangeOfChunkSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1408750194_0;
    EntityQuery __query_1408750194_1;
    EntityQuery __query_1408750194_2;
    EntityQuery __query_1408750194_3;
    
    // unmanaged system, skipped generating example queries

}
