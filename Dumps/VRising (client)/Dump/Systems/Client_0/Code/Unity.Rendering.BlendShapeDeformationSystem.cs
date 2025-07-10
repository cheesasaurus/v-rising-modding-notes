using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(Unity.Rendering.DeformationsInPresentation))]
[UpdateAfter(typeof(Unity.Rendering.InstantiateDeformationSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class BlendShapeDeformationSystem : SystemBase
{
    EntityQuery m_BlendWeightQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_BlendWeightQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Deformations.BlendShapeWeight>(),
            },
        });
        
    }
    

}
