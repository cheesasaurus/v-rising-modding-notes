using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEventOnSpawnSystem : SystemBase
{
    EntityQuery __query_1606952066_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1606952066_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CreateGameplayEventsOnSpawn>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
