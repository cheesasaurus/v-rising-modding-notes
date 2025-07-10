using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[UpdateAfter(typeof(ProjectM.Network.MakePacketSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SendPacketSystem : SystemBase
{
    EntityQuery __query_435576346_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_435576346_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.User>(),
                ComponentType.ReadWrite<ProjectM.Network.UserNetBuffer>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
    }
    

}
