using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.BeforeSequencerUpdateGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class Pull_RotationSystem : SystemBase
{
    EntityQuery __query_723887600_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_723887600_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.Pull_Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.BlackboardElement>(),
            },
        });
        
    }
    

}
