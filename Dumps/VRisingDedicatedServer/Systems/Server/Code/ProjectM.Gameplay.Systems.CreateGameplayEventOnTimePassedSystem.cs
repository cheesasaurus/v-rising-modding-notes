using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEventOnTimePassedSystem : SystemBase
{
    EntityQuery __query_1198435760_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1198435760_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadWrite<ProjectM.CreateGameplayEventsOnTimePassed>(),
            },
        });
        
    }
    

}
