using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEventOnTickSystem : SystemBase
{
    EntityQuery __query_1698607192_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1698607192_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
                ComponentType.ReadWrite<ProjectM.CreateGameplayEventsOnTick>(),
            },
        });
        
    }
    

}
