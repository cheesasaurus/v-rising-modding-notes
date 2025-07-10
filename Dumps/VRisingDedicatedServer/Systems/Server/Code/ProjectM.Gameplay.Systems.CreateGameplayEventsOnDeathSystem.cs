using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[UpdateBefore(typeof(ProjectM.DestroyDeathEventSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEventsOnDeathSystem : SystemBase
{
    EntityQuery __query_1365518674_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1365518674_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
    }
    

}
