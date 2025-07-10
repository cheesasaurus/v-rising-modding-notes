using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[UpdateAfter(typeof(ProjectM.DeathEventListenerSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class Cleanup_BuffModificationsSystem_Server : SystemBase
{
    EntityQuery _DeathEventQuery;
    EntityQuery __query_1912026676_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DeathEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
        __query_1912026676_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.FollowBuffOwnerModifications>(),
                ComponentType.ReadOnly<ProjectM.FollowBuffOwner>(),
            },
        });
        
    }
    

}
