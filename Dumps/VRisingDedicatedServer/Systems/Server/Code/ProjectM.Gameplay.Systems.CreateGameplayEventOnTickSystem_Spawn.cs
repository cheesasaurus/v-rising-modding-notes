using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEventOnTickSystem_Spawn : SystemBase
{
    EntityQuery __query_1698607170_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1698607170_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CreateGameplayEventsOnTick>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
