using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.BeforeSequencerUpdateGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class Pull_PositionSystem : SystemBase
{
    EntityQuery __query_1344350711_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1344350711_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.Pull_Position>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.BlackboardElement>(),
            },
        });
        
    }
    

}
