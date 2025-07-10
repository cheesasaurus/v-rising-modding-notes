using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
public class ClientChatSystem : SystemBase, ProjectM.IInputContext
{
    EntityQuery _ReceiveChatMessagesQuery;
    EntityQuery __query_172511207_0;
    EntityQuery __query_172511207_1;
    EntityQuery __query_172511207_2;
    EntityQuery __query_172511207_3;
    EntityQuery __query_172511207_4;
    EntityQuery __query_172511207_5;
    EntityQuery __query_172511207_6;
    EntityQuery __query_172511207_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ReceiveChatMessagesQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ChatMessageServerEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.ReceiveNetworkEventTag>(),
            },
        });
        
        __query_172511207_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.ToggleChatEvent>(),
            },
        });
        
        __query_172511207_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ChatMessageServerEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.ReceiveNetworkEventTag>(),
            },
        });
        
        __query_172511207_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ChatMessageServerEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.ReceiveNetworkEventTag>(),
            },
        });
        
        __query_172511207_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_172511207_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_172511207_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.ChatInputFocused>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_172511207_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalUser>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_172511207_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalCharacter>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
