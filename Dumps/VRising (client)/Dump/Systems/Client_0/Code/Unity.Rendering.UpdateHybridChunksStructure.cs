using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(Unity.Rendering.StructuralChangePresentationSystemGroup))]
public class UpdateHybridChunksStructure : SystemBase
{
    EntityQuery m_MissingHybridChunkInfo;
    EntityQuery m_DisabledRenderingQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_MissingHybridChunkInfo = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.WorldRenderBounds>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<Unity.Rendering.MaterialMeshInfo>(),
                ComponentType.ReadOnly<Unity.Rendering.ChunkWorldRenderBounds>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.DisableRendering>(),
                ComponentType.ReadOnly<Unity.Rendering.EntitiesGraphicsChunkInfo>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        m_DisabledRenderingQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.DisableRendering>(),
                ComponentType.ReadOnly<Unity.Rendering.EntitiesGraphicsChunkInfo>(),
            },
        });
        
    }
    

}
