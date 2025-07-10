using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class VerifyingRepairAbilitySystem : SystemBase
{
    EntityQuery _QueryAbilityCastFinishedEvent;
    EntityQuery __query_1291645_0;
    EntityQuery __query_1291645_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _QueryAbilityCastFinishedEvent = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPreCastFinishedEvent>(),
            },
        });
        
        __query_1291645_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastStartedEvent>(),
            },
        });
        
        __query_1291645_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPreCastEndedEvent>(),
            },
        });
        
    }
    

}
