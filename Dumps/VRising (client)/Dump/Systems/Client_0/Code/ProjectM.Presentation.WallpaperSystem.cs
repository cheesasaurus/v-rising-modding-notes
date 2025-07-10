using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(ProjectM.WallpaperGroup))]
public struct WallpaperSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _LastFrameWallpaperUpdatedEventsQuery;
    EntityQuery _WallpaperUpdate_0;
    EntityQuery _WallpaperUpdate_90;
    EntityQuery _WallpaperUpdate_180;
    EntityQuery _WallpaperUpdate_270;
    EntityQuery __query_1779854724_0;
    EntityQuery __query_1779854724_1;
    EntityQuery __query_1779854724_2;
    EntityQuery __query_1779854724_3;
    EntityQuery __query_1779854724_4;
    
    // unmanaged system, skipped generating example queries

}
