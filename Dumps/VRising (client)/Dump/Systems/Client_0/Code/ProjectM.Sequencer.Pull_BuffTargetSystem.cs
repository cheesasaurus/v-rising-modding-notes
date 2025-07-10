using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.BeforeSequencerUpdateGroup), OrderFirst = true)]
[UpdateAfter(typeof(ProjectM.Sequencer.Pull_EntitySystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class Pull_BuffTargetSystem : SystemBase
{
    EntityQuery __query_1412899705_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1412899705_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.Pull_BuffTarget>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.BlackboardElement>(),
            },
        });
        
    }
    

}
