using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class GetVBloodsPositionResponseSystem : SystemBase
{
    EntityQuery _ResponseEntityQuery;
    EntityQuery __query_1929673659_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ResponseEntityQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.GetVBloodPositionsResponseEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.ReceiveNetworkEventTag>(),
            },
        });
        
        __query_1929673659_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.GetVBloodPositionsResponseEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.ReceiveNetworkEventTag>(),
            },
        });
        
    }
    

}
