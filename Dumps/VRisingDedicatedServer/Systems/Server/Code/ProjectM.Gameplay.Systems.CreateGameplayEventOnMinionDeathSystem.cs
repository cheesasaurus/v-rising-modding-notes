using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEventOnMinionDeathSystem : SystemBase
{
    EntityQuery __query_1553012393_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1553012393_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MinionRemovedEvent>(),
            },
        });
        
    }
    

}
