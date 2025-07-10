using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityGroup))]
[UpdateAfter(typeof(ProjectM.AbilityInitializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AbilityStopSequenceOnInterrupt_Client : SystemBase
{
    EntityQuery __query_335314861_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_335314861_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityInterruptedEvent>(),
            },
        });
        
    }
    

}
