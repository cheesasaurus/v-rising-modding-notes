using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.WallpaperGroup), OrderLast = true)]
public struct DeferredWallpaperPlacementSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2013418345_0;
    EntityQuery __query_2013418345_1;
    
    // unmanaged system, skipped generating example queries

}
