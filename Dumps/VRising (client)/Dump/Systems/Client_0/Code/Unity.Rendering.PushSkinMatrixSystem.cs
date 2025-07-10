using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(Unity.Rendering.DeformationsInPresentation))]
[UpdateBefore(typeof(Unity.Rendering.SkinningDeformationSystem))]
[UpdateAfter(typeof(Unity.Rendering.PushMeshDataSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class PushSkinMatrixSystem : SystemBase
{
    EntityQuery m_SkinningEntityQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_SkinningEntityQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.DeformedEntity>(),
                ComponentType.ReadOnly<Unity.Rendering.SkinMatrixBufferIndex>(),
                ComponentType.ReadOnly<Unity.Rendering.SharedMeshTracker>(),
            },
        });
        
    }
    

}
