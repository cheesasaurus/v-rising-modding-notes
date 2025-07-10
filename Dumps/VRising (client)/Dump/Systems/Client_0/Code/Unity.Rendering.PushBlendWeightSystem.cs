using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(Unity.Rendering.DeformationsInPresentation))]
[UpdateBefore(typeof(Unity.Rendering.BlendShapeDeformationSystem))]
[UpdateAfter(typeof(Unity.Rendering.PushMeshDataSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class PushBlendWeightSystem : SystemBase
{
    EntityQuery m_BlendShapedEntityQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_BlendShapedEntityQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.DeformedEntity>(),
                ComponentType.ReadOnly<Unity.Rendering.BlendWeightBufferIndex>(),
                ComponentType.ReadOnly<Unity.Rendering.SharedMeshTracker>(),
            },
        });
        
    }
    

}
