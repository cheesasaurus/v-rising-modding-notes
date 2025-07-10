using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEventOnDistanceReachedSystem : SystemBase
{
    EntityQuery __query_178680558_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_178680558_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CreateGameplayEventOnDistanceReached>(),
            },
        });
        
    }
    

}
