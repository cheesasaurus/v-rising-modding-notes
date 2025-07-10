using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
[UpdateAfter(typeof(ProjectM.Tiles.TileModelSpatialLookupSystem))]
public struct TileHeightSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_457961060_0;
    EntityQuery __query_457961060_1;
    
    // unmanaged system, skipped generating example queries

}
