using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ServerResetScheduleSystem_Client : SystemBase
{
    EntityQuery _ScheduleNotificationEventsQuery;
    EntityQuery __query_2025512432_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ScheduleNotificationEventsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ResetScheduleNotificationEvent>(),
            },
        });
        
        __query_2025512432_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ResetScheduleNotificationEvent>(),
            },
        });
        
    }
    

}
