using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.SetHybridModelAnimationSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class ChestAimTargetWeightAnimationSystem : SystemBase
{
    EntityQuery __query_1866984743_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1866984743_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.AnimatorLastState>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelAnimationComponent>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModelPlayerTransformData>(),
            },
        });
        
    }
    

}
