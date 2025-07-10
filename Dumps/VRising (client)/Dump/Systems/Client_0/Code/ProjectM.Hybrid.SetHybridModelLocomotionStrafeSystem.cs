using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetHybridModelLocomotionStrafeSystem : SystemBase
{
    EntityQuery __query_1676039444_0;
    EntityQuery __query_1676039444_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1676039444_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelStrafeLocomotionData>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelLocomotionComponent>(),
            },
        });
        
        __query_1676039444_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelDOTSAnimator>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelStrafeLocomotionData>(),
            },
        });
        
    }
    

}
