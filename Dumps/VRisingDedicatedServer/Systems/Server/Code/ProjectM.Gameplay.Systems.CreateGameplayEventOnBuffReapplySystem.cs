using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.ResetBuffEventSystem_Server))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEventOnBuffReapplySystem : SystemBase
{
    EntityQuery __query_456393843_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_456393843_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.BuffReappliedEvent>(),
            },
        });
        
    }
    

}
