using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UserInfoBufferSystem_Client : SystemBase
{
    EntityQuery _ConnectedQuery;
    EntityQuery _UserInfoServerEventQuery;
    EntityQuery _UserInfoSyncEvent;
    EntityQuery _DisconnectedQuery;
    EntityQuery __query_1133664107_0;
    EntityQuery __query_1133664107_1;
    EntityQuery __query_1133664107_2;
    EntityQuery __query_1133664107_3;
    EntityQuery __query_1133664107_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ConnectedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserConnectedServerEvent>(),
            },
        });
        
        _UserInfoServerEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserInfoServerEvent>(),
            },
        });
        
        _UserInfoSyncEvent = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.UserInfoSyncEvent>(),
            },
        });
        
        _DisconnectedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserDisconnectedServerEvent>(),
            },
        });
        
        __query_1133664107_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserConnectedServerEvent>(),
            },
        });
        
        __query_1133664107_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserInfoServerEvent>(),
            },
        });
        
        __query_1133664107_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.UserInfoSyncEvent>(),
            },
        });
        
        __query_1133664107_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserDisconnectedServerEvent>(),
            },
        });
        
        __query_1133664107_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UserInfoBufferSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
