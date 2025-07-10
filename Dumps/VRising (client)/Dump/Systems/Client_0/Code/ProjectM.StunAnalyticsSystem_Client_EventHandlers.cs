using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class StunAnalyticsSystem_Client_EventHandlers : SystemBase
{
    EntityQuery _UserKillServerEventQuery;
    EntityQuery _UserDownedServerEventQuery;
    EntityQuery __query_1762304676_0;
    EntityQuery __query_1762304676_1;
    EntityQuery __query_1762304676_2;
    EntityQuery __query_1762304676_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _UserKillServerEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserKillServerEvent>(),
            },
        });
        
        _UserDownedServerEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserDownedServerEvent>(),
            },
        });
        
        __query_1762304676_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserDownedServerEvent>(),
            },
        });
        
        __query_1762304676_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserKillServerEvent>(),
            },
        });
        
        __query_1762304676_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPreCastFinishedEvent>(),
            },
        });
        
        __query_1762304676_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityInterruptedEvent>(),
            },
        });
        
    }
    

}
