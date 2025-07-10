using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.BeforeSequencerUpdateGroup), OrderFirst = true)]
[UpdateAfter(typeof(ProjectM.Sequencer.Pull_EntitySystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class Pull_TeamSystem : SystemBase
{
    EntityQuery __query_51487720_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_51487720_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.Pull_Team>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.BlackboardElement>(),
            },
        });
        
    }
    

}
