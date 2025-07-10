using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToChunkLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ChunkDataRemappingManager : SystemBase, ProjectM.IDeclareTerrainChunkDependenciesOnLoad
{
    EntityQuery _EntityQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EntityQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLoadedEvent>(),
            },
        });
        
    }
    

}
