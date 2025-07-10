using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.BeforeSequencerUpdateGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class Pull_InputSystem : SystemBase
{
    EntityQuery __query_1948411399_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1948411399_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.Pull_Input>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.BlackboardElement>(),
            },
        });
        
    }
    

}
