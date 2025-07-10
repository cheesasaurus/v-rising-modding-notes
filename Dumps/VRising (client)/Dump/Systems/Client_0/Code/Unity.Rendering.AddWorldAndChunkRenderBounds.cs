using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(Unity.Rendering.StructuralChangePresentationSystemGroup))]
public class AddWorldAndChunkRenderBounds : SystemBase
{
    EntityQuery m_MissingWorldRenderBounds;
    EntityQuery m_MissingWorldChunkRenderBounds;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_MissingWorldRenderBounds = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.RenderBounds>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.WorldRenderBounds>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        m_MissingWorldChunkRenderBounds = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.RenderBounds>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.ChunkWorldRenderBounds>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
