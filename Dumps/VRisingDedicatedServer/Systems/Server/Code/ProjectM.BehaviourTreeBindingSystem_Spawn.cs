using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BehaviourTreeBindingSystem_Spawn : SystemBase
{
    EntityQuery __query_1372982342_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1372982342_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Behaviours.BehaviourTreeInstance>(),
                ComponentType.ReadOnly<ProjectM.Behaviours.BehaviourTreeBinding>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.BlackboardElement>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
