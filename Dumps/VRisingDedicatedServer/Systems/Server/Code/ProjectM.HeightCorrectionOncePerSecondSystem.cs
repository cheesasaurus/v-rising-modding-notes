using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.MapCollisionSystem))]
public struct HeightCorrectionOncePerSecondSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _SnapItemPickupToHeightJobQuery;
    EntityQuery __query_496389207_0;
    
    // unmanaged system, skipped generating example queries

}
