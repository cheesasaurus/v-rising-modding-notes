using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SequenceDestroyerSystem : SystemBase
{
    EntityQuery __query_1770315813_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1770315813_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Stunlock.Sequencer.SequenceInstance>(),
            },
        });
        
    }
    

}
