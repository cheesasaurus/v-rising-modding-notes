using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ServantMissionSystem_Client : SystemBase
{
    EntityQuery _MissionStartedEventQuery;
    EntityQuery _MissionFinishedEventQuery;
    EntityQuery __query_262912893_0;
    EntityQuery __query_262912893_1;
    EntityQuery __query_262912893_2;
    EntityQuery __query_262912893_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MissionStartedEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ServantMissionStartedEvent>(),
            },
        });
        
        _MissionFinishedEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ServantMissionFinishedEvent>(),
            },
        });
        
        __query_262912893_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ServantMissionFinishedEvent>(),
            },
        });
        
        __query_262912893_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ServantMissionStartedEvent>(),
            },
        });
        
        __query_262912893_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_262912893_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServantMissionSettingsSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
