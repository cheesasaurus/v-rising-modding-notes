using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CollisionDetectionSystem_StaticEntities_ReactToDestroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _StaticDestroyedQuery;
    EntityQuery __query_998139042_0;
    
    // unmanaged system, skipped generating example queries

}
