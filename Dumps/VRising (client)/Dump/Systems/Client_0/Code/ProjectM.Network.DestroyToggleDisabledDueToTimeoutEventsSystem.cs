using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[UpdateBefore(typeof(ProjectM.Network.ReceivePacketSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroyToggleDisabledDueToTimeoutEventsSystem : SystemBase
{
    EntityQuery _Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ToggleDisabledDueToTimeoutEvent>(),
            },
        });
        
    }
    

}
