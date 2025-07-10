using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEventOnDestroySystem : SystemBase
{
    EntityQuery __query_1297357609_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1297357609_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DestroyData>(),
                ComponentType.ReadWrite<ProjectM.CreateGameplayEventsOnDestroy>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
