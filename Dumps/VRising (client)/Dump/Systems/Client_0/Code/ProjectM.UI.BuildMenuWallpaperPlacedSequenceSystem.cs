using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.WallpaperGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct BuildMenuWallpaperPlacedSequenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _WallpaperPlacedEvents;
    EntityQuery __query_2013418531_0;
    EntityQuery __query_2013418531_1;
    EntityQuery __query_2013418531_2;
    EntityQuery __query_2013418531_3;
    
    // unmanaged system, skipped generating example queries

}
