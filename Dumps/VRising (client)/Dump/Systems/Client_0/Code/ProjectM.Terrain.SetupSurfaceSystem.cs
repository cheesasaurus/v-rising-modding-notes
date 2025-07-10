using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(Unity.Rendering.EntitiesGraphicsSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetupSurfaceSystem : SystemBase
{
    EntityQuery _NewTerrainQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _NewTerrainQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLoadedEvent>(),
            },
        });
        
    }
    

}
