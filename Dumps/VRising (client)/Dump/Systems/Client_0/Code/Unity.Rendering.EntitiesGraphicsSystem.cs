using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(Unity.Rendering.UpdatePresentationSystemGroup))]
public class EntitiesGraphicsSystem : SystemBase
{
    EntityQuery m_CullingJobDependencyGroup;
    EntityQuery m_EntitiesGraphicsRenderedQuery;
    EntityQuery m_EntitiesGraphicsRenderedQueryRO;
    EntityQuery m_LodSelectGroup;
    EntityQuery m_ChangedTransformQuery;
    EntityQuery m_MetaEntitiesForHybridRenderableChunksQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_CullingJobDependencyGroup = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.RootLODWorldReferencePoint>(),
                ComponentType.ReadOnly<Unity.Rendering.RootLODRange>(),
                ComponentType.ReadOnly<Unity.Rendering.LODWorldReferencePoint>(),
                ComponentType.ReadOnly<Unity.Rendering.LODRange>(),
                ComponentType.ReadOnly<Unity.Rendering.WorldRenderBounds>(),
                ComponentType.ReadOnly<Unity.Entities.ChunkHeader>(),
                ComponentType.ReadOnly<Unity.Rendering.EntitiesGraphicsChunkInfo>(),
                ComponentType.ReadOnly<Unity.Rendering.ChunkWorldRenderBounds>(),
            },
        });
        
        m_EntitiesGraphicsRenderedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.WorldRenderBounds>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<Unity.Rendering.MaterialMeshInfo>(),
                ComponentType.ReadWrite<Unity.Rendering.EntitiesGraphicsChunkInfo>(),
                ComponentType.ReadOnly<Unity.Rendering.ChunkWorldRenderBounds>(),
            },
        });
        
        m_EntitiesGraphicsRenderedQueryRO = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.WorldRenderBounds>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<Unity.Rendering.MaterialMeshInfo>(),
                ComponentType.ReadOnly<Unity.Rendering.EntitiesGraphicsChunkInfo>(),
                ComponentType.ReadOnly<Unity.Rendering.ChunkWorldRenderBounds>(),
            },
        });
        
        m_LodSelectGroup = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Rendering.EntitiesGraphicsChunkInfo>(),
                ComponentType.ReadOnly<Unity.Entities.ChunkHeader>(),
            },
        });
        
        m_ChangedTransformQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadWrite<Unity.Rendering.EntitiesGraphicsChunkInfo>(),
            },
        });
        
        m_MetaEntitiesForHybridRenderableChunksQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Rendering.EntitiesGraphicsChunkInfo>(),
                ComponentType.ReadOnly<Unity.Entities.ChunkHeader>(),
            },
        });
        
    }
    

}
