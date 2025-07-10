using Unity.Entities;

namespace ProjectM.CastleBuilding.Systems;


[UpdateInGroup(typeof(ProjectM.BuildModeGroup))]
[UpdateAfter(typeof(ProjectM.CastleBuilding.Systems.BuildModeSystem))]
public struct FadeOutFloorsReplacedByStairsPreviewSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_574862306_0;
    EntityQuery __query_574862306_1;
    
    // unmanaged system, skipped generating example queries

}
