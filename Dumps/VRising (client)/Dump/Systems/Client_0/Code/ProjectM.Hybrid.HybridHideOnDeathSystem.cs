using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.Sequencer.SequencerEarlyUpdateGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.HybridModelSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class HybridHideOnDeathSystem : SystemBase
{
    EntityQuery __query_1463142166_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1463142166_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModel>(),
                ComponentType.ReadWrite<ProjectM.HybridHideOnDeathComponent>(),
            },
        });
        
    }
    

}
