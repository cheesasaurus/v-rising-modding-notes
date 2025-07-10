using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.SetHybridModelAnimationSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class AnimatorLayerFadeSystem : SystemBase
{
    EntityQuery __query_1866984463_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1866984463_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Hybrid.AnimationLayerBuffer>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelAnimationComponent>(),
            },
        });
        
    }
    

}
