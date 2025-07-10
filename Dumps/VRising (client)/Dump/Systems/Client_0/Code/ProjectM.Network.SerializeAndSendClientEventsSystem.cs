using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SerializeAndSendClientEventsSystem : SystemBase
{
    EntityQuery _Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.SendNetworkEventTag>(),
            },
        });
        
    }
    

}
