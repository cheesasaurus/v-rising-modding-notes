using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.ReactToSceneLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TerrainManager : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery _ChunkMetadatasToInitializeQuery;
    EntityQuery _NewLoadedMetadataQuery;
    EntityQuery _NewTerrainChunksQuery;
    EntityQuery _UnloadedTerrainChunksQuery;
    EntityQuery __query_1780669238_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLoadedEvent>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkUnloadedEvent>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkMetadataLoadedEvent>(),
            },
        });
        
        _ChunkMetadatasToInitializeQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkMetadata>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.ProcessedMetadataTag>(),
            },
        });
        
        _NewLoadedMetadataQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkMetadata>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.ProcessedMetadataTag>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.StartedLoadingTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.LoadedMetadataTag>(),
            },
        });
        
        _NewTerrainChunksQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.RegisteredLoadedTerrainChunk>(),
            },
        });
        
        _UnloadedTerrainChunksQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.RegisteredLoadedTerrainChunk>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainTag>(),
            },
        });
        
        __query_1780669238_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Terrain.TerrainManager.SystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
