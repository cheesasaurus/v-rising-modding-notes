using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class KickBanSystem_Client : SystemBase
{
    EntityQuery _BannedResponseQuery;
    EntityQuery __query_1201276576_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _BannedResponseQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.BannedEvent.Reponse>(),
            },
        });
        
        __query_1201276576_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.BannedEvent.Reponse>(),
            },
        });
        
    }
    

}
