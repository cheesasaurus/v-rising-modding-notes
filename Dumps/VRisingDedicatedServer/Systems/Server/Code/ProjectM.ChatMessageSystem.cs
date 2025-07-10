using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ChatMessageSystem : SystemBase
{
    EntityQuery _ChatMessageQuery;
    EntityQuery _ConnectedUsersQuery;
    EntityQuery __query_661171423_0;
    EntityQuery __query_661171423_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ChatMessageQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.ChatMessageEvent>(),
            },
        });
        
        _ConnectedUsersQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ConnectedUser>(),
            },
        });
        
        __query_661171423_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.ChatMessageEvent>(),
            },
        });
        
        __query_661171423_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
