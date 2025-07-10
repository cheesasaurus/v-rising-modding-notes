using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.TeleportationRequestSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class TeleportToWaypointEventSystem : SystemBase
{
    EntityQuery _TeleportToWaypointEventQuery;
    EntityQuery _TeleportToNetherEventQuery;
    EntityQuery _DebugTeleportToNetherEventQuery;
    EntityQuery _DebugTeleportToEntityEventQuery;
    EntityQuery __query_1956534509_0;
    EntityQuery __query_1956534509_1;
    EntityQuery __query_1956534509_2;
    EntityQuery __query_1956534509_3;
    EntityQuery __query_1956534509_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _TeleportToWaypointEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.TeleportEvents_ToServer.TeleportToWaypointEvent>(),
            },
        });
        
        _TeleportToNetherEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.TeleportEvents_ToServer.TeleportToNetherEvent>(),
            },
        });
        
        _DebugTeleportToNetherEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.TeleportEvents_ToServer.DebugTeleportToNetherEvent>(),
            },
        });
        
        _DebugTeleportToEntityEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.TeleportEvents_ToServer.DebugTeleportToEntityEvent>(),
            },
        });
        
        __query_1956534509_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.TeleportEvents_ToServer.TeleportToWaypointEvent>(),
            },
        });
        
        __query_1956534509_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.TeleportEvents_ToServer.TeleportToNetherEvent>(),
            },
        });
        
        __query_1956534509_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.TeleportEvents_ToServer.DebugTeleportToEntityEvent>(),
            },
        });
        
        __query_1956534509_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.TeleportEvents_ToServer.DebugTeleportToNetherEvent>(),
            },
        });
        
        __query_1956534509_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
