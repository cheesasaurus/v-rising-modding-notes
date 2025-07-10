using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToEntityHitConsumedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEventOnOwnerSpellHitConsumedSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1751328393_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CreateGameplayEventsOnOwnerSpellHitConsumed>(),
            },
        });
        
        __query_1751328393_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityHitConsumedEvent>(),
            },
        });
        
    }
    

}
