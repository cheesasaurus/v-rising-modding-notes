using Unity.Entities;

namespace ProjectM.Tiles;


[UpdateInGroup(typeof(ProjectM.ReactToTilePositionGroup))]
public struct TileWorldSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _LoadedChunkEventQuery;
    EntityQuery _UnloadedChunkEventQuery;
    EntityQuery __query_629420249_0;
    
    // unmanaged system, skipped generating example queries

}
