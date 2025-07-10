using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityReactDuringCastGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroyEntityOnAbilityEndedSystem : SystemBase
{
    EntityQuery __query_1381200222_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1381200222_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityCastEndedEvent>(),
            },
        });
        
    }
    

}
