using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.BeforeSequencerUpdateGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class Pull_EntitySystem : SystemBase
{
    EntityQuery __query_826673958_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_826673958_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Sequencer.SequenceInstance>(),
                ComponentType.ReadOnly<ProjectM.Sequencer.Pull_Entity>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.BlackboardElement>(),
            },
        });
        
    }
    

}
