using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CollisionDetectionSystem_StaticEntities_ReactToSpawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _StaticSpawnedQuery;
    EntityQuery _TotalStaticSpawnedQuery;
    EntityQuery _StaticIdleInteractionPointsQuery;
    EntityQuery _TotalStaticIdleInteractionPointsQuery;
    EntityQuery __query_998138931_0;
    EntityQuery __query_998138931_1;
    
    // unmanaged system, skipped generating example queries

}
