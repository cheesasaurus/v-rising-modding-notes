using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
public struct DisableWhenNoPlayersInRangeOfChunk_ReactToPersistenceLoad : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1408750140_0;
    EntityQuery __query_1408750140_1;
    
    // unmanaged system, skipped generating example queries

}
