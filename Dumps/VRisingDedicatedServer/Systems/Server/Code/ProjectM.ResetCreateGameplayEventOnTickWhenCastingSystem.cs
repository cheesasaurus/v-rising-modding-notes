using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityReactDuringCastGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ResetCreateGameplayEventOnTickWhenCastingSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1123849456_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ResetCreateGameplayEventsOnTickWhenCasting>(),
            },
        });
        
        __query_1123849456_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ResetCreateGameplayEventsOnTickWhenCasting>(),
            },
        });
        
    }
    

}
