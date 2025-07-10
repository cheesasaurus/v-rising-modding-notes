using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SystemMessageSystem : SystemBase
{
    EntityQuery _SystemMessageQuery;
    EntityQuery _UserQuery;
    EntityQuery __query_661171602_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _SystemMessageQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ServerSystemChatMessage>(),
            },
        });
        
        _UserQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.Network.ConnectedUser>(),
            },
        });
        
        __query_661171602_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerSystemChatMessage>(),
            },
        });
        
    }
    

}
