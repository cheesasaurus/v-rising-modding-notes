using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.BeforeSerializeBarrierGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SerializeAndSendServerEventsSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery _IncorrectQuery;
    EntityQuery __query_1536085433_0;
    EntityQuery __query_1536085433_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkEventType>(),
                ComponentType.ReadOnly<ProjectM.Network.SendNetworkEventTag>(),
            },
        });
        
        _IncorrectQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkEventType>(),
                ComponentType.ReadOnly<ProjectM.Network.SendNetworkEventTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.SendEventToUser>(),
                ComponentType.ReadOnly<ProjectM.Network.SendEventToUsers>(),
            },
        });
        
        __query_1536085433_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkEventType>(),
                ComponentType.ReadOnly<ProjectM.Network.SendEventToUsers>(),
                ComponentType.ReadOnly<ProjectM.Network.SendNetworkEventTag>(),
            },
        });
        
        __query_1536085433_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkEventType>(),
                ComponentType.ReadOnly<ProjectM.Network.SendEventToUser>(),
                ComponentType.ReadOnly<ProjectM.Network.SendNetworkEventTag>(),
            },
        });
        
    }
    

}
