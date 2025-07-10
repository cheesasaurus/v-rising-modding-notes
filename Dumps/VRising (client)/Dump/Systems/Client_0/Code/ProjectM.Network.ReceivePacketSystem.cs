using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[UpdateBefore(typeof(ProjectM.DeserializeComponentsGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ReceivePacketSystem : SystemBase
{
    EntityQuery _CreateEntitiesQuery;
    EntityQuery _ReceivePacketQuery;
    EntityQuery __query_1322613859_0;
    EntityQuery __query_1322613859_1;
    EntityQuery __query_1322613859_2;
    EntityQuery __query_1322613859_3;
    EntityQuery __query_1322613859_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _CreateEntitiesQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.ReceivedPacket>(),
                ComponentType.ReadOnly<ProjectM.Network.ReceivedPacketBuffer>(),
            },
        });
        
        _ReceivePacketQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ReceivedPacket>(),
                ComponentType.ReadOnly<ProjectM.Network.ReceivedPacketBuffer>(),
            },
        });
        
        __query_1322613859_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1322613859_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ItemKeyLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1322613859_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClientNetworkState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1322613859_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1322613859_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HailMessageStruct_Server>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
