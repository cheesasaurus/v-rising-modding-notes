using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToContestEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class StunAnalyticsSystem_Server_ContestEventHandlers : SystemBase
{
    EntityQuery _ContestFinishedServerEventQuery;
    EntityQuery _ContestCancelledServerEventQuery;
    EntityQuery _ContestStartedServerEventQuery;
    EntityQuery __query_1762305077_0;
    EntityQuery __query_1762305077_1;
    EntityQuery __query_1762305077_2;
    EntityQuery __query_1762305077_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ContestFinishedServerEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestInstance.FinishedEvent>(),
            },
        });
        
        _ContestCancelledServerEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestInstance.CancelledEvent>(),
            },
        });
        
        _ContestStartedServerEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestInstance.StartingEvent>(),
            },
        });
        
        __query_1762305077_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestInstance.CancelledEvent>(),
            },
        });
        
        __query_1762305077_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestInstance.FinishedEvent>(),
            },
        });
        
        __query_1762305077_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestInstance.StartingEvent>(),
            },
        });
        
        __query_1762305077_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
