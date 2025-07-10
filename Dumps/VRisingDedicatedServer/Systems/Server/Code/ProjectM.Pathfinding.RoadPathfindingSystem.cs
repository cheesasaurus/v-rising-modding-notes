using Unity.Entities;

namespace ProjectM.Pathfinding;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RoadPathfindingSystem : SystemBase
{
    EntityQuery _PathfindingQuery;
    EntityQuery __query_513953838_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _PathfindingQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Terrain.RoadPathfindingRequest>(),
                ComponentType.ReadWrite<ProjectM.Terrain.RoadPathfindingResult>(),
            },
        });
        
        __query_513953838_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldRoadGraph>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
