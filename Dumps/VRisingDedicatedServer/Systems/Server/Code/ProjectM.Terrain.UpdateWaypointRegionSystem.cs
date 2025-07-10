using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateWaypointRegionSystem : SystemBase
{
    EntityQuery _WaypointRegionsQuery;
    EntityQuery _UserQuery;
    EntityQuery __query_870474544_0;
    EntityQuery __query_870474544_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _WaypointRegionsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WaypointRegionPolygon>(),
                ComponentType.ReadOnly<ProjectM.Terrain.WorldRegionPolygonVertex>(),
            },
        });
        
        _UserQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
        __query_870474544_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WaypointRegionPolygon>(),
                ComponentType.ReadOnly<ProjectM.Terrain.WorldRegionPolygonVertex>(),
            },
        });
        
        __query_870474544_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
    }
    

}
