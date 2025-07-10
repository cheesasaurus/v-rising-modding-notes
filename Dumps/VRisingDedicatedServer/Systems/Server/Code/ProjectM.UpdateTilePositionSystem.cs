using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[UpdateBefore(typeof(ProjectM.ReactToTilePositionGroup))]
public struct UpdateTilePositionSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _CalculateChangeQuery;
    EntityQuery __query_875087221_0;
    
    // unmanaged system, skipped generating example queries

}
