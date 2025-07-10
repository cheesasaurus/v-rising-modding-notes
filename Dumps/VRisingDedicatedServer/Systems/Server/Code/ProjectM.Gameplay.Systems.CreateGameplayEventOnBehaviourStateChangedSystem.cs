using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEventOnBehaviourStateChangedSystem : SystemBase
{
    EntityQuery _CreateGameplayEventonBehaviourStateEnteredQuery;
    EntityQuery __query_221632411_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _CreateGameplayEventonBehaviourStateEnteredQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CreateGameplayEventOnBehaviourStateChanged>(),
            },
        });
        
        __query_221632411_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Behaviours.BehaviourTreeStateChangedEvent>(),
            },
        });
        
    }
    

}
