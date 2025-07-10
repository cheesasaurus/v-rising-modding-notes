using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetHybridModelLocomotionSystem : SystemBase
{
    EntityQuery __query_1676039321_0;
    EntityQuery __query_1676039321_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1676039321_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelDOTSAnimator>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelLocomotionData>(),
            },
        });
        
        __query_1676039321_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelLocomotionData>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelLocomotionComponent>(),
            },
        });
        
    }
    

}
