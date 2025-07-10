using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.SetHybridModelLocomotionSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetHybridModelAnimationSystem : SystemBase
{
    EntityQuery __query_1866984023_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1866984023_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Hybrid.AnimatorPlayAnimationBuffer>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.AnimationLayerBuffer>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelAnimationComponent>(),
            },
        });
        
    }
    

}
