using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroyBuffsWithDeadTargetsOrOwnersSystem : SystemBase
{
    EntityQuery _DeathEventQuery;
    EntityQuery __query_401358822_0;
    EntityQuery __query_401358822_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DeathEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
        __query_401358822_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
        __query_401358822_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Buff_Destroy_On_Owner_Death>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
