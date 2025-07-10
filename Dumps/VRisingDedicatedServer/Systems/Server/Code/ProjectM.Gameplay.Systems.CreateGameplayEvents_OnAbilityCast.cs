using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.AbilityGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEvents_OnAbilityCast : SystemBase
{
    EntityQuery __query_1365518405_0;
    EntityQuery __query_1365518405_1;
    EntityQuery __query_1365518405_2;
    EntityQuery __query_1365518405_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1365518405_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastStartedEvent>(),
            },
        });
        
        __query_1365518405_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPreCastFinishedEvent>(),
            },
        });
        
        __query_1365518405_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPostCastFinishedEvent>(),
            },
        });
        
        __query_1365518405_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityInterruptedEvent>(),
            },
        });
        
    }
    

}
