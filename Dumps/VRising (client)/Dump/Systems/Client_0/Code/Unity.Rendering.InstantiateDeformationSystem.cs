using Unity.Entities;

namespace Unity.Rendering;


[UpdateInGroup(typeof(Unity.Rendering.DeformationsInPresentation))]
[UpdateAfter(typeof(Unity.Rendering.PushMeshDataSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class InstantiateDeformationSystem : SystemBase
{
    EntityQuery m_Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        m_Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Rendering.DeformedMeshIndex>(),
                ComponentType.ReadOnly<Unity.Rendering.SharedMeshTracker>(),
            },
        });
        
    }
    

}
