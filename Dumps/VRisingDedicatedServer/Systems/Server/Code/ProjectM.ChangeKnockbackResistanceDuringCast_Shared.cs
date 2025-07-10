using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityReactDuringCastGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ChangeKnockbackResistanceDuringCast_Shared : SystemBase
{
    EntityQuery __query_1589524844_0;
    EntityQuery __query_1589524844_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1589524844_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastStartedEvent>(),
            },
        });
        
        __query_1589524844_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastEndedEvent>(),
            },
        });
        
    }
    

}
