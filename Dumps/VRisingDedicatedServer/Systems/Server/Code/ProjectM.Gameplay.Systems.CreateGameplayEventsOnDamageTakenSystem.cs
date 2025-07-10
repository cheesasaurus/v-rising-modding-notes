using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.StatChangeSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateGameplayEventsOnDamageTakenSystem : SystemBase
{
    EntityQuery _CreateGameplayEventsOnDamageTakenQuery;
    EntityQuery _DamageTakenEventQuery;
    EntityQuery __query_1365518774_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _CreateGameplayEventsOnDamageTakenQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CreateGameplayEventOnDamageTaken>(),
            },
        });
        
        _DamageTakenEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DamageTakenEvent>(),
            },
        });
        
        __query_1365518774_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DamageTakenEvent>(),
            },
        });
        
    }
    

}
