using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[UpdateAfter(typeof(ProjectM.ReactToTileBoundsGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct TeleportPlayersOutOfCollisionSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _UpdateQuery;
    EntityQuery __query_844125974_0;
    EntityQuery __query_844125974_1;
    
    // unmanaged system, skipped generating example queries

}
