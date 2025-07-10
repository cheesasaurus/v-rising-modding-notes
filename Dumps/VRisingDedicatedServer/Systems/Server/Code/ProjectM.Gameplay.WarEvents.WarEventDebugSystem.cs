using Unity.Entities;

namespace ProjectM.Gameplay.WarEvents;


[UpdateInGroup(typeof(ProjectM.Gameplay.WarEvents.WarEventUpdateGroup))]
[UpdateBefore(typeof(ProjectM.Gameplay.WarEvents.WarEventSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class WarEventDebugSystem : SystemBase
{
    EntityQuery _StartEvents;
    EntityQuery _ScheduleEvents;
    EntityQuery _SetRemainingTimeEvents;
    EntityQuery _CloseGateEvents;
    EntityQuery _ClosePortalEvents;
    EntityQuery _SimulateActiveEventUsersEvents;
    EntityQuery _SimulateActiveGateUsersEvents;
    EntityQuery __query_759590075_0;
    EntityQuery __query_759590075_1;
    EntityQuery __query_759590075_2;
    EntityQuery __query_759590075_3;
    EntityQuery __query_759590075_4;
    EntityQuery __query_759590075_5;
    EntityQuery __query_759590075_6;
    EntityQuery __query_759590075_7;
    EntityQuery __query_759590075_8;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _StartEvents = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_StartEvent>(),
            },
        });
        
        _ScheduleEvents = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_ScheduleEvent>(),
            },
        });
        
        _SetRemainingTimeEvents = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_SetRemainingTime>(),
            },
        });
        
        _CloseGateEvents = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_CloseGateEvent>(),
            },
        });
        
        _ClosePortalEvents = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_ClosePortalEvent>(),
            },
        });
        
        _SimulateActiveEventUsersEvents = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_SimulateEventActiveUsers>(),
            },
        });
        
        _SimulateActiveGateUsersEvents = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_SimulateGateActiveUsers>(),
            },
        });
        
        __query_759590075_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_StartEvent>(),
            },
        });
        
        __query_759590075_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_ScheduleEvent>(),
            },
        });
        
        __query_759590075_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_SetRemainingTime>(),
            },
        });
        
        __query_759590075_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_CloseGateEvent>(),
            },
        });
        
        __query_759590075_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_ClosePortalEvent>(),
            },
        });
        
        __query_759590075_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_SimulateEventActiveUsers>(),
            },
        });
        
        __query_759590075_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.WarEvent_SimulateGateActiveUsers>(),
            },
        });
        
        __query_759590075_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.WarEvents.WarEvent_DebugData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_759590075_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Shared.WarEvents.WarEvent_DebugData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
