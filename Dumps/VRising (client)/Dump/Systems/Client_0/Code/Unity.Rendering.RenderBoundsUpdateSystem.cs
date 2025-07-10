using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(Unity.Rendering.UpdatePresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RenderBoundsUpdateSystem : SystemBase
{
    EntityQuery m_WorldRenderBounds;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_WorldRenderBounds = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.RenderBounds>(),
                ComponentType.ReadWrite<Unity.Rendering.WorldRenderBounds>(),
                ComponentType.ReadOnly<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadWrite<Unity.Rendering.ChunkWorldRenderBounds>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.SkipWorldRenderBoundsUpdate>(),
            },
        });
        
    }
    

}
