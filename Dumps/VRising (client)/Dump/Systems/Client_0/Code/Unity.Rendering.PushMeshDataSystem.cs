using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(Unity.Rendering.DeformationsInPresentation))]
[RequireMatchingQueriesForUpdateAttribute]
public class PushMeshDataSystem : SystemBase
{
    EntityQuery m_LayoutDeformedMeshesQuery;
    EntityQuery __query_1205703448_0;
    EntityQuery __query_1205703448_1;
    EntityQuery __query_1205703448_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_LayoutDeformedMeshesQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.DeformedEntity>(),
                ComponentType.ReadWrite<Unity.Rendering.DeformedMeshIndex>(),
                ComponentType.ReadOnly<Unity.Rendering.MaterialMeshInfo>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Rendering.BlendWeightBufferIndex>(),
                ComponentType.ReadWrite<Unity.Rendering.SkinMatrixBufferIndex>(),
            },
            Options = EntityQueryOptions.IgnoreComponentEnabledState,
        });
        
        __query_1205703448_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.DeformedEntity>(),
                ComponentType.ReadOnly<Unity.Rendering.SharedMeshTracker>(),
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
        });
        
        __query_1205703448_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.SharedMeshTracker>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.DeformedEntity>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1205703448_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.DeformedEntity>(),
                ComponentType.ReadOnly<Unity.Rendering.MaterialMeshInfo>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.SharedMeshTracker>(),
            },
        });
        
    }
    

}
