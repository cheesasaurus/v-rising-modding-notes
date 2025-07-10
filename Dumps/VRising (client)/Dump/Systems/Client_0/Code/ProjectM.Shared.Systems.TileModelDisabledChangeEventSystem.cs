using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[UpdateBefore(typeof(ProjectM.UpdateTilePositionSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct TileModelDisabledChangeEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_151631371_0;
    EntityQuery __query_151631371_1;
    
    // unmanaged system, skipped generating example queries

}
