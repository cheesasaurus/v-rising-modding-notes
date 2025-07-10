using Unity.Entities;

namespace ProjectM.Tiles;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
public struct TileModelSpatialLookupSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _AddedQuery;
    EntityQuery _UpdatedQuery;
    EntityQuery _RemovedQuery;
    
    // unmanaged system, skipped generating example queries

}
