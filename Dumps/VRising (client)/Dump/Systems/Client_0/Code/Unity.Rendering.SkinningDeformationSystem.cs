using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(Unity.Rendering.DeformationsInPresentation))]
[UpdateAfter(typeof(Unity.Rendering.BlendShapeDeformationSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SkinningDeformationSystem : SystemBase
{
    EntityQuery m_SkinMatrixQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_SkinMatrixQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Unity.Deformations.SkinMatrix>(),
            },
        });
        
    }
    

}
