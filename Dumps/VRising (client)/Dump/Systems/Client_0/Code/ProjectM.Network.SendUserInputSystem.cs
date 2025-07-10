using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[UpdateAfter(typeof(ProjectM.Network.SerializeAndSendUserInputSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SendUserInputSystem : SystemBase
{
    EntityQuery __query_1984122489_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1984122489_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ClientNetworkState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
