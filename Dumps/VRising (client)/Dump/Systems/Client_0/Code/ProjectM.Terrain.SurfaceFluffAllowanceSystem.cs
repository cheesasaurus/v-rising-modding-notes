using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
[UpdateAfter(typeof(ProjectM.Terrain.CalculateDirtyFluffChunksSystem))]
public struct SurfaceFluffAllowanceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _TerrainChunksQuery;
    EntityQuery _SurfaceFluffTileModelDataQuery;
    EntityQuery __query_759474818_0;
    
    // unmanaged system, skipped generating example queries

}
