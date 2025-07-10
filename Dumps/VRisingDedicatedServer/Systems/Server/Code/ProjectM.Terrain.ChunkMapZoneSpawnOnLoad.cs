using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.ReactToChunkLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ChunkMapZoneSpawnOnLoad : SystemBase, ProjectM.IDeclareTerrainChunkDependenciesOnLoad
{
    EntityQuery _RequiredQuery;
    EntityQuery __query_181571268_0;
    EntityQuery __query_181571268_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RequiredQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkMetadataLoadedEvent>(),
            },
        });
        
        __query_181571268_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkMetadataLoadedEvent>(),
            },
        });
        
        __query_181571268_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
