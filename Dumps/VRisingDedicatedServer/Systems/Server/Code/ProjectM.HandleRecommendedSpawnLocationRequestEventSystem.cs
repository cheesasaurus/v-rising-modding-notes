using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HandleRecommendedSpawnLocationRequestEventSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery __query_55431038_0;
    EntityQuery __query_55431038_1;
    EntityQuery __query_55431038_2;
    EntityQuery __query_55431038_3;
    EntityQuery __query_55431038_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.RecommendedSpawnLocationRequestEvent>(),
            },
        });
        
        __query_55431038_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.RecommendedSpawnLocationRequestEvent>(),
            },
        });
        
        __query_55431038_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldRegionPolygon>(),
                ComponentType.ReadOnly<ProjectM.Terrain.WorldRegionPolygonVertex>(),
            },
        });
        
        __query_55431038_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.StartGraveyardExitWaypoint>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Interactable>(),
            },
        });
        
        __query_55431038_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
                ComponentType.ReadOnly<ProjectM.Team>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
        __query_55431038_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.Team>(),
                ComponentType.ReadOnly<ProjectM.Terrain.CurrentWorldRegion>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
    }
    

}
