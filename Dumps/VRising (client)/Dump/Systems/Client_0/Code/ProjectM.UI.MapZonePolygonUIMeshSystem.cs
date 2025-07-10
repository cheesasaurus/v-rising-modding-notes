using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MapZonePolygonUIMeshSystem : SystemBase
{
    EntityQuery __query_1512143284_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1512143284_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.MapZoneData>(),
                ComponentType.ReadWrite<ProjectM.Terrain.MapZonePolygonVertexElement>(),
                ComponentType.ReadWrite<ProjectM.Terrain.MapZoneDiscoverableElement>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UiPolygonMesh>(),
            },
        });
        
    }
    

}
