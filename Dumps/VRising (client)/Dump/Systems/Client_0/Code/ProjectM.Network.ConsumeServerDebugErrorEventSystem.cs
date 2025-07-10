using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class ConsumeServerDebugErrorEventSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery __query_2137844640_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ServerDebugErrorEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.ReceiveNetworkEventTag>(),
            },
        });
        
        __query_2137844640_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ServerDebugErrorEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.ReceiveNetworkEventTag>(),
            },
        });
        
    }
    

}
